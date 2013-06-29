#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable

namespace Code.Domain.Features.SearchPlayers
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search for players")]
    public partial class SearchForPlayersFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "SearchPlayers.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(
                new System.Globalization.CultureInfo("en-US"),
                "Search for players",
                "",
                ProgrammingLanguage.CSharp,
                ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
#line 3
#line 4
            testRunner.Given("a set of players", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line hidden
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for players by name")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void SearchForPlayersByName()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Search for players by name",
                new string[]
                {
                    "mytag"
                });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 3
            this.FeatureBackground();
#line 8
            testRunner.Given(
                "a player with name Neymar", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 9
            testRunner.When("I enter Ney as name", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 10
            testRunner.And("I search", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 11
            testRunner.Then("I get Neymar in results", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for players by potential")]
        public virtual void SearchForPlayersByPotential()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Search for players by potential", ((string[]) (null)));
#line 13
            this.ScenarioSetup(scenarioInfo);
#line 3
            this.FeatureBackground();
#line 14
            testRunner.Given(
                "a player with potential abliity 150", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 15
            testRunner.When("I enter potential 100", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 16
            testRunner.And("I search", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 17
            testRunner.Then(
                "I get every player with potential greater than or equal to 100",
                ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)),
                "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for players by current ability")]
        public virtual void SearchForPlayersByCurrentAbility()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Search for players by current ability", ((string[]) (null)));
#line 19
            this.ScenarioSetup(scenarioInfo);
#line 3
            this.FeatureBackground();
#line 20
            testRunner.Given(
                "a player with current ability 150", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 21
            testRunner.When(
                "I enter current ability 100", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 22
            testRunner.And("I search", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 23
            testRunner.Then(
                "I get every player with current ability greater than or equal to 100",
                ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)),
                "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for players by position")]
        public virtual void SearchForPlayersByPosition()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for players by position", ((string[]) (null)));
#line 25
            this.ScenarioSetup(scenarioInfo);
#line 3
            this.FeatureBackground();
#line 26
            testRunner.Given(
                "a player with ability 15 in central midfield",
                ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 27
            testRunner.When(
                "I enter position central midfield", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 28
            testRunner.And(
                "I enter ability in position 15", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 29
            testRunner.And("I search", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 30
            testRunner.Then(
                "I get every player with ability in central midfield greater than or equal to 15",
                ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)),
                "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for players by age")]
        public virtual void SearchForPlayersByAge()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for players by age", ((string[]) (null)));
#line 32
            this.ScenarioSetup(scenarioInfo);
#line 3
            this.FeatureBackground();
#line 33
            testRunner.Given("a player with age 19", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 34
            testRunner.When("I enter age 20", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 35
            testRunner.And("I search", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 36
            testRunner.Then(
                "I get every player with age less than or equal to 20",
                ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)),
                "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion