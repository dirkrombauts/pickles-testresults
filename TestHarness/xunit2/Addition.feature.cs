﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles.TestHarness.xunit2
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AdditionFeature : Xunit.IClassFixture<AdditionFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Addition.feature"
#line hidden
        
        public AdditionFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Addition", "  In order to avoid silly mistakes\r\n  As a math idiot\r\n  I want to be told the su" +
                    "m of two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
  testRunner.Given("the calculator has clean memory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SetFixture(AdditionFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Addition")]
        [Xunit.TraitAttribute("Description", "Adding several numbers")]
        [Xunit.TraitAttribute("Category", "tag2")]
        [Xunit.InlineDataAttribute("60", "70", "130", "260", new string[0])]
        [Xunit.InlineDataAttribute("40", "50", "90", "180", new string[0])]
        public virtual void AddingSeveralNumbers(string firstNumber, string secondNumber, string thirdNumber, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding several numbers", @__tags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
  testRunner.Given(string.Format("I have entered {0} into the calculator", firstNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
  testRunner.And(string.Format("I have entered {0} into the calculator", secondNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And(string.Format("I have entered {0} into the calculator", thirdNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
  testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Addition")]
        [Xunit.TraitAttribute("Description", "Add two numbers")]
        [Xunit.TraitAttribute("Category", "tag1")]
        public virtual void AddTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", new string[] {
                        "tag1"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 24
  testRunner.Given("I have entered 1 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
  testRunner.And("I have entered 2 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
  testRunner.Then("the result should be 3 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Addition")]
        [Xunit.TraitAttribute("Description", "Fail to add two numbers")]
        [Xunit.TraitAttribute("Category", "tag1")]
        public virtual void FailToAddTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fail to add two numbers", new string[] {
                        "tag1"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 31
  testRunner.Given("I have entered 1 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
  testRunner.And("I have entered 2.2 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
  testRunner.Then("the result should be 3.2 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Addition")]
        [Xunit.TraitAttribute("Description", "Ignored adding two numbers")]
        public virtual void IgnoredAddingTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ignored adding two numbers", new string[] {
                        "ignore"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
  testRunner.Given("I have entered 1 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
  testRunner.And("I have entered 2.2 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
  testRunner.Then("the result should be 3.2 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Addition")]
        [Xunit.TraitAttribute("Description", "Not automated adding two numbers")]
        public virtual void NotAutomatedAddingTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not automated adding two numbers", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 44
  testRunner.Given("unimplemented step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
  testRunner.When("unimplemented step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
  testRunner.Then("unimplemented step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AdditionFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AdditionFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
