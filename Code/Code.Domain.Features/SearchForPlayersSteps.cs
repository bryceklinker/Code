using System;
using TechTalk.SpecFlow;

namespace Code.Domain.Features
{
    [Binding]
    public class SearchForPlayersSteps
    {
        [Given(@"a set of players")]
        public void GiveASetOfPlayers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a player with name (.*)")]
        public void GivenAPlayerWithName(string name)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*) as name")]
        public void WhenIEnterName(string name)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search")]
        public void WhenISearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter potential (.*)")]
        public void WhenIEnterPotential(int potential)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter current ability (.*)")]
        public void WhenIEnterCurrentAbility(int currentAbility)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter position (.*)")]
        public void WhenIEnterPosition(string position)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter age (.*)")]
        public void WhenIEnterAge(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get (.*) in results")]
        public void ThenIGetInResults(string name)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get every player with potential greater than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithPotentialGreaterThanOrEqualTo(int potential)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get every player with current ability greater than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithCurrentAbilityGreaterThanOrEqualTo(int currentAbility)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get every player with position (.*)")]
        public void ThenIGetEveryPlayerWithPosition(string position)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get every player with age less than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithAgeLessThanOrEqualTo(int age)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
