// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Soroban.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NumberGenerator")]
    public partial class NumberGeneratorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "NumberGenerator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "NumberGenerator", "Number generator.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Number generation with digit count.")]
        [NUnit.Framework.CategoryAttribute("twoDigit")]
        public virtual void NumberGenerationWithDigitCount_()
        {
            string[] tagsOfScenario = new string[] {
                    "twoDigit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Number generation with digit count.", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "DigitCount",
                            "NumberCountToGenerate"});
                table1.AddRow(new string[] {
                            "1",
                            "1"});
                table1.AddRow(new string[] {
                            "1",
                            "2"});
                table1.AddRow(new string[] {
                            "2",
                            "1"});
                table1.AddRow(new string[] {
                            "2",
                            "2"});
                table1.AddRow(new string[] {
                            "3",
                            "1"});
                table1.AddRow(new string[] {
                            "3",
                            "2"});
                table1.AddRow(new string[] {
                            "3",
                            "3"});
                table1.AddRow(new string[] {
                            "9",
                            "45"});
#line 6
        testRunner.Given("entered digit number and generated number count is like below", ((string)(null)), table1, "Given ");
#line hidden
#line 16
        testRunner.When("generate is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "EachLessThan",
                            "GeneratedNumberCount"});
                table2.AddRow(new string[] {
                            "10",
                            "1"});
                table2.AddRow(new string[] {
                            "10",
                            "2"});
                table2.AddRow(new string[] {
                            "100",
                            "1"});
                table2.AddRow(new string[] {
                            "100",
                            "2"});
                table2.AddRow(new string[] {
                            "1000",
                            "1"});
                table2.AddRow(new string[] {
                            "1000",
                            "2"});
                table2.AddRow(new string[] {
                            "1000",
                            "3"});
                table2.AddRow(new string[] {
                            "1000000000",
                            "45"});
#line 17
        testRunner.Then("the generated numbers", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
