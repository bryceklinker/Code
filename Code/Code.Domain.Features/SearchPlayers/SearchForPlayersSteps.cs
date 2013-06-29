using System.Linq;
using Code.Domain.Entities;
using Code.Domain.Entities.Models;
using Code.Domain.Features.Fakes;
using Code.Domain.Features.SearchPlayers.Fakes;
using Code.Domain.Gateways;
using Code.Domain.SearchPlayers;
using Code.Domain.SearchPlayers.Models;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Code.Domain.Features.SearchPlayers
{
    [Binding]
    public class SearchForPlayersSteps
    {
        private readonly PlayerGateway _playerGateway;
        private readonly SearchPlayersInteractor _interactor;
        private readonly FakeSearchPlayersConsumerBoundary _consumerBoundary;
        private readonly SearchPlayersRequest _request;
        private readonly FakeContext _context;

        public SearchForPlayersSteps()
        {
            _context = new FakeContext();
            _consumerBoundary = new FakeSearchPlayersConsumerBoundary();

            _playerGateway = new PlayerGatewayImp(_context);
            _interactor = new SearchPlayersInteractor(_playerGateway, _consumerBoundary);

            _request = new SearchPlayersRequest
            {
                Position = new Position()
            };
        }

        [Given(@"a set of players")]
        public void GivenASetOfPlayers()
        {
            _context.InitializePlayers(200);
        }

        [Given(@"a player with name (.*)")]
        public void GivenAPlayerWithName(string name)
        {
            var playerModel = new PlayerModel
            {
                Name = name
            };
            _context.AddPlayer(playerModel);
        }

        [Given(@"a player with potential abliity (.*)")]
        public void GivenAPlayerWithPotentialAbility(int potential)
        {
            var playerModel = new PlayerModel
            {
                PotentialAbilty = potential
            };
            _context.AddPlayer(playerModel);
        }

        [Given(@"a player with current ability (.*)")]
        public void GivenAPlayerWithCurrentAbility(int ability)
        {
            var playerModel = new PlayerModel
            {
                CurrentAbility = ability
            };
            _context.AddPlayer(playerModel);
        }

        [Given(@"a player with ability (.*) in (.*)")]
        public void GivenAPlayerWithAbilityInPosition(int ability, string position)
        {
            var playerModel = new PlayerModel
            {
                Positions = new[]
                {
                    new Position
                    {
                        Ability = ability,
                        Name = position
                    }
                }
            };
            _context.AddPlayer(playerModel);
        }

        [Given(@"a player with age (.*)")]
        public void GivenAPlayerWithAge(int age)
        {
            var playerModel = new PlayerModel
            {
                Age = age
            };
            _context.AddPlayer(playerModel);
        }

        [When(@"I enter (.*) as name")]
        public void WhenIEnterName(string name)
        {
            _request.Name = name;
        }

        [When(@"I search")]
        public void WhenISearch()
        {
            _interactor.SearchPlayers(_request);
        }

        [When(@"I enter potential (.*)")]
        public void WhenIEnterPotential(int potential)
        {
            _request.PotentialAbility = potential;
        }

        [When(@"I enter current ability (.*)")]
        public void WhenIEnterCurrentAbility(int currentAbility)
        {
            _request.CurrentAbility = currentAbility;
        }

        [When(@"I enter position (.*)")]
        public void WhenIEnterPosition(string position)
        {
            _request.Position.Name = position;
        }

        [When(@"I enter ability in position (.*)")]
        public void WhenIEnterAbilityInPosition(int ability)
        {
            _request.Position.Ability = ability;
        }

        [When(@"I enter age (.*)")]
        public void WhenIEnterAge(int age)
        {
            _request.Age = age;
        }

        [Then(@"I get (.*) in results")]
        public void ThenIGetInResults(string name)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.Name.Contains(name)));
        }

        [Then(@"I get every player with potential greater than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithPotentialGreaterThanOrEqualTo(int potential)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.PotentialAbility >= potential));
        }

        [Then(@"I get every player with current ability greater than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithCurrentAbilityGreaterThanOrEqualTo(int currentAbility)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.CurrentAbility >= currentAbility));
        }

        [Then(@"I get every player with position (.*)")]
        public void ThenIGetEveryPlayerWithPosition(string position)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.Positions.Any(po => po.Name == position)));
        }

        [Then(@"I get every player with age less than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithAgeLessThanOrEqualTo(int age)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.Age <= age));
        }

        [Then(@"I get every player with ability in (.*) greater than or equal to (.*)")]
        public void ThenIGetEveryPlayerWithAbilityInPositionGreaterThanOrEqualTo(string position, int ability)
        {
            Assert.IsTrue(_consumerBoundary.Response.Players.All(p => p.Positions.Any(po => po.Ability >= ability)));
        }
    }
}