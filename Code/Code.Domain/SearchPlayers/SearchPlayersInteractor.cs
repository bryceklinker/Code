using System.Collections.Generic;
using System.Linq;
using Code.Domain.Entities;
using Code.Domain.Gateways;
using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.SearchPlayers
{
    public class SearchPlayersInteractor : SearchPlayersProducerBoundary
    {
        private readonly PlayerGateway _gateway;
        private readonly SearchPlayersConsumerBoundary _consumerBoundary;

        public SearchPlayersInteractor(PlayerGateway gateway, SearchPlayersConsumerBoundary consumerBoundary)
        {
            _gateway = gateway;
            _consumerBoundary = consumerBoundary;
        }

        public void SearchPlayers(SearchPlayersRequest request)
        {
            var players = _gateway.GetPlayers(request);
            var response = new SearchPlayersResponse
            {
                Players = ConvertPlayers(players)
            };
            _consumerBoundary.SetPlayers(response);
        }

        private IEnumerable<SearchPlayerModel> ConvertPlayers(IEnumerable<Player> players)
        {
            return players.Select(p => new SearchPlayerModel
            {
                Age = p.GetAge(),
                CurrentAbility = p.GetAbility(),
                Name = p.GetName(),
                Positions = p.GetPositions(),
                PotentialAbility = p.GetPotential()
            })
                .ToList();
        }
    }
}