// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Calculadora.Test
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CalculadoraFeature : object, Xunit.IClassFixture<CalculadoraFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Soma.feature"
#line hidden
        
        public CalculadoraFeature(CalculadoraFeature.FixtureData fixtureData, Calculadora_Test_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Calculadora", "Uma calculadora simples que tem apenas a operação de adição.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Add two integer numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Add two integer numbers")]
        [Xunit.InlineDataAttribute("10", "15", "25", new string[0])]
        [Xunit.InlineDataAttribute("45", "1", "46", new string[0])]
        [Xunit.InlineDataAttribute("-1", "-1", "-2", new string[0])]
        [Xunit.InlineDataAttribute("-10", "10", "0", new string[0])]
        [Xunit.InlineDataAttribute("2147483647", "1", "-2147483648", new string[0])]
        public virtual void AddTwoIntegerNumbers(string value1, string value2, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two integer numbers", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("the first int value is {0}", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And(string.Format("the second int value is {0}", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.Then(string.Format("the int result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Add two double numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Add two double numbers")]
        [Xunit.InlineDataAttribute("10.56", "15.47", "26.03", new string[0])]
        [Xunit.InlineDataAttribute("0.1", "0.01", "0.11", new string[0])]
        [Xunit.InlineDataAttribute("0", "0", "0", new string[0])]
        [Xunit.InlineDataAttribute("-55.48", "50.47", "-5.01", new string[0])]
        [Xunit.InlineDataAttribute("2147483647.67455434", "1", "2147483648.67455434", new string[0])]
        public virtual void AddTwoDoubleNumbers(string value1, string value2, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two double numbers", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given(string.Format("the first double value is {0}", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.And(string.Format("the second double value is {0}", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then(string.Format("the double result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Add two decimal numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Add two decimal numbers")]
        [Xunit.InlineDataAttribute("10.56", "15.47", "26.03", new string[0])]
        [Xunit.InlineDataAttribute("0.1", "0.01", "0.11", new string[0])]
        [Xunit.InlineDataAttribute("0", "0", "0", new string[0])]
        [Xunit.InlineDataAttribute("-55.48", "50.47", "-5.01", new string[0])]
        [Xunit.InlineDataAttribute("79228162514264337593543950334", "1", "79228162514264337593543950335", new string[0])]
        public virtual void AddTwoDecimalNumbers(string value1, string value2, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two decimal numbers", null, exampleTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given(string.Format("the first decimal value is {0}", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.And(string.Format("the second decimal value is {0}", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then(string.Format("the decimal result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Concatenate two strings")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Concatenate two strings")]
        [Xunit.InlineDataAttribute("\'Nathan\'", "\' Lacerda\'", "\'Nathan Lacerda\'", new string[0])]
        [Xunit.InlineDataAttribute("\'Con\'", "\'catenate\'", "\'Concatenate\'", new string[0])]
        [Xunit.InlineDataAttribute("\'12\'", "\'34\'", "\'1234\'", new string[0])]
        [Xunit.InlineDataAttribute("\'ab\'", "\'dc\'", "\'abdc\'", new string[0])]
        [Xunit.InlineDataAttribute("\'\"He\'", "\'y!\"\'", "\'\"Hey!\"\'", new string[0])]
        public virtual void ConcatenateTwoStrings(string value1, string value2, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Concatenate two strings", null, exampleTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
 testRunner.Given(string.Format("the first string value is {0}", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 47
 testRunner.And(string.Format("the second string value is {0}", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.Then(string.Format("the string result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Try to add two bool")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Try to add two bool")]
        [Xunit.InlineDataAttribute("true", "true", new string[0])]
        [Xunit.InlineDataAttribute("true", "false", new string[0])]
        [Xunit.InlineDataAttribute("false", "true", new string[0])]
        [Xunit.InlineDataAttribute("false", "false", new string[0])]
        public virtual void TryToAddTwoBool(string value1, string value2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to add two bool", null, exampleTags);
#line 58
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 59
    testRunner.Given(string.Format("the first bool is \'{0}\'", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 60
    testRunner.And(string.Format("the second bool is \'{0}\'", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
    testRunner.Then("the bool result should be an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Try to add two date")]
        [Xunit.TraitAttribute("FeatureTitle", "Calculadora")]
        [Xunit.TraitAttribute("Description", "Try to add two date")]
        [Xunit.InlineDataAttribute("15/06/2009 13:45:30", "01/05/1970 14:51:09", new string[0])]
        [Xunit.InlineDataAttribute("12/05/1970 14:51:09", "13/01/1970 04:12:49", new string[0])]
        [Xunit.InlineDataAttribute("21/01/2001 00:21:59", "30/03/1970 12:00:00", new string[0])]
        [Xunit.InlineDataAttribute("12/05/1970 22:22:22", "15/03/1970 02:01:09", new string[0])]
        public virtual void TryToAddTwoDate(string value1, string value2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to add two date", null, exampleTags);
#line 70
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 71
    testRunner.Given(string.Format("the first date is \'{0}\'", value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 72
    testRunner.And(string.Format("the second date is \'{0}\'", value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
    testRunner.Then("the date result should be an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CalculadoraFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CalculadoraFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
