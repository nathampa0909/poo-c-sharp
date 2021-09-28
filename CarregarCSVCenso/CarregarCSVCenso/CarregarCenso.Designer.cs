namespace CarregarCSVCenso
{
    partial class CarregueCenso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.pgbProgresso = new System.Windows.Forms.ProgressBar();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(75, 127);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(503, 20);
            this.txtURL.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(113, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(395, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Carrega Dados do Censo e gera consulta";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(72, 111);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(167, 13);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "Digite a URL e clique em carregar";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(283, 153);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(75, 217);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(503, 23);
            this.pgbProgresso.TabIndex = 4;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(72, 201);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(54, 13);
            this.lblProgresso.TabIndex = 5;
            this.lblProgresso.Text = "Progresso";
            // 
            // CarregueCenso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 268);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.pgbProgresso);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtURL);
            this.Name = "CarregueCenso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ProgressBar pgbProgresso;
        private System.Windows.Forms.Label lblProgresso;
    }
}

