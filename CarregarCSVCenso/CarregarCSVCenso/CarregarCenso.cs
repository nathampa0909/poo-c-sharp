using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarregarCSVCenso
{
    public partial class CarregueCenso : Form
    {
        private string _diretorio = Path.GetTempPath() + @"\microdados";
        private string _arquivo = Path.GetTempPath() + @"\microdados\microdados.zip";
        private List<string> _linhas = new List<String>();
        private List<string> _instituicoes = new List<string>();
        private Dictionary<string, string> _cursos = new Dictionary<string, string>();
        private WebClient _client = new WebClient();

        public CarregueCenso()
        {
            InitializeComponent();
        }

        private void CarregueCsvCensoEscolarDeURL(string url)
        {
            if (File.Exists(_arquivo))
            {
                DescompacteLogoAposCrieArquivo();
                return;
            }

            Directory.CreateDirectory(_diretorio);
            _client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            _client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            _client.DownloadFileTaskAsync(new Uri(url), _arquivo);
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                var bytesIn = double.Parse(e.BytesReceived.ToString());
                var totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                var percentage = bytesIn / totalBytes * 100;
                lblProgresso.Text = "Progresso: " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                pgbProgresso.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                lblProgresso.Text = "Progresso: Completo";
                pgbProgresso.Value = 100;
                DescompacteLogoAposCrieArquivo();
            });
        }

        private void DescompacteLogoAposCrieArquivo()
        {
            if (Directory.GetDirectories(_diretorio).Length < 1)
                ZipFile.ExtractToDirectory(_arquivo, _diretorio);

            _diretorio = Directory.GetDirectories(_diretorio).First();

            string linha;

            var arquivo = new StreamReader(_diretorio + @"\dados\DM_IES.CSV", Encoding.GetEncoding(new CultureInfo("pt-BR").TextInfo.ANSICodePage));
            arquivo.ReadLine();
            while ((linha = arquivo.ReadLine()) != null)
            {
                var linhaSeparada = linha.Split('|');

                if (linhaSeparada[2] == null || linhaSeparada[2] == "")
                {
                    continue;
                }

                _instituicoes.Add(FixeNomeIncorreto(linhaSeparada[2]));
            }

            _instituicoes.OrderBy(s => s);

            var arquivoCursos = new StreamReader(_diretorio + @"\dados\DM_CURSO.CSV", Encoding.GetEncoding(new CultureInfo("pt-BR").TextInfo.ANSICodePage));
            arquivoCursos.ReadLine();
            while ((linha = arquivoCursos.ReadLine()) != null)
            {
                var linhaSeparada = linha.Split('|');
                var possuiTipoDeCursoNoNome = FixeNomeIncorreto(linhaSeparada[9]).ToLower().Contains("licenciatura") ||
                    FixeNomeIncorreto(linhaSeparada[9]).ToLower().Contains("bacharelado");
                var tipoDeCurso = possuiTipoDeCursoNoNome ? "" : "- " + ObtenhaTipoDeCurso(int.Parse(linhaSeparada[10]));
                var curso = $"{ FixeNomeIncorreto(linhaSeparada[9]) } { tipoDeCurso }".ToUpper();

                if (_cursos.ContainsKey(curso))
                {
                    continue;
                }

                _cursos.Add(curso, linhaSeparada[11]);
            }

            AdicioneLinha("DELETE FROM TBINSTITUICAO");

            var contador = 1;
            var colecaoDeInstituicoes = _instituicoes.OrderBy(i => i);
            foreach (var ins in colecaoDeInstituicoes)
            {
                AdicioneLinha($"INSERT INTO TBINSTITUICAO (INSTITUICAOID, INSTITUICAODESCRICAO) VALUES('{ contador++ }', '{ ins.ToUpper() }')");
            }

            AdicioneLinha("INSERT INTO TBINSTITUICAO (INSTITUICAOID, INSTITUICAODESCRICAO) VALUES('9999999', 'INSTITUIÇÃO NÃO CADASTRADA')");

            AdicioneLinha("DELETE FROM TBCURSODEFORMACAOSUPERIOR");
            AdicioneLinha("ALTER TABLE TBCURSODEFORMACAOSUPERIOR ALTER CURSOCHAVE TYPE Char(7)");
            AdicioneLinha("ALTER TABLE TBCURSODEFORMACAOSUPERIOR ALTER CURSODESCRICAO TYPE Varchar(200)");

            contador = 1;
            var colecaoDeCursos = _cursos.OrderBy(c => c.Key);
            foreach (var curso in colecaoDeCursos)
            {
                AdicioneLinha("INSERT INTO TBCURSODEFORMACAOSUPERIOR (CURSOID, CURSOCHAVE, CURSODESCRICAO) " +
                    $"VALUES ('{ contador++ }', '{ curso.Value.ToUpper() }', '{ curso.Key.ToUpper() }')");
            }

            AdicioneLinha($"INSERT INTO TBCURSODEFORMACAOSUPERIOR (CURSOID, CURSOCHAVE, CURSODESCRICAO) VALUES('{ contador++ }', '9999990', 'OUTRO CURSO DE FORMAÇÃO SUPERIOR - LICENCIATURA')");
            AdicioneLinha($"INSERT INTO TBCURSODEFORMACAOSUPERIOR (CURSOID, CURSOCHAVE, CURSODESCRICAO) VALUES('{ contador++ }', '9999991', 'OUTRO CURSO DE FORMAÇÃO SUPERIOR - BACHARELADO')");
            AdicioneLinha($"INSERT INTO TBCURSODEFORMACAOSUPERIOR (CURSOID, CURSOCHAVE, CURSODESCRICAO) VALUES('{ contador++ }', '9999992', 'OUTRO CURSO DE FORMAÇÃO SUPERIOR - TECNOLÓGICO')");


            _linhas.ForEach(texto =>
            {
                var utf8 = Encoding.UTF8;
                var ptBR = Encoding.GetEncoding(new CultureInfo("pt-BR").TextInfo.ANSICodePage);
                var ptBRBytes = ptBR.GetBytes(texto);
                var isoBytes = Encoding.Convert(ptBR, utf8, ptBRBytes);
                texto = utf8.GetString(isoBytes);
            }
            );

            File.WriteAllLines(_diretorio + @"\insercao.sql", _linhas, Encoding.UTF8);
            MessageBox.Show("Finalizado!");
        }

        private void AdicioneLinha(string linha)
        {
            _linhas.Add("--#start");
            _linhas.Add(linha);
            _linhas.Add("--#end");
        }

        private string FixeNomeIncorreto(string nome)
        {
            if (nome.Contains("'"))
            {
                nome = nome.Replace("'", "''");
            }

            if (nome.Contains("¿"))
            {
                nome = nome.Replace("¿", "''");
            }

            nome = nome.Replace("\"", "");

            return nome;
        }

        private string ObtenhaTipoDeCurso(int numero)
        {
            if (numero == 1)
            {
                return "BACHARELADO";
            }

            if (numero == 2)
            {
                return "LICENCIATURA";
            }

            if (numero == 3)
            {
                return "TECNOLÓGICO";
            }

            return null;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregueCsvCensoEscolarDeURL(txtURL.Text);
            btnCarregar.Enabled = false;
        }
    }
}
