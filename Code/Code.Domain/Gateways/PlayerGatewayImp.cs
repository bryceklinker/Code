using System.Collections.Generic;
using System.Linq;
using Code.Domain.Entities;
using Code.Domain.Entities.Models;
using Code.Domain.Gateways.Contexts;
using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.Gateways
{
    public class PlayerGatewayImp : PlayerGateway
    {
        private readonly Context _context;

        public PlayerGatewayImp(Context context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetPlayers(SearchPlayersRequest request)
        {
            var players = _context.Players;
            players = FilterOnAge(request, players);
            players = FilterOnCurrentAbility(request, players);
            players = FilterOnName(request, players);
            players = FilterOnPosition(request, players);
            players = FiliterOnPotentialAbility(request, players);

            return players.Select(Player.CreatePlayer);
        }

        private static IEnumerable<PlayerModel> FiliterOnPotentialAbility(SearchPlayersRequest request, IEnumerable<PlayerModel> players)
        {
            if (request.PotentialAbility.HasValue)
                players = players.Where(p => p.PotentialAbilty >= request.PotentialAbility.Value);
            return players;
        }

        private static IEnumerable<PlayerModel> FilterOnPosition(SearchPlayersRequest request, IEnumerable<PlayerModel> players)
        {
            if (request.Position == null)
                return players;

            if (request.Position.Ability > 0)
                players = players
                    .Where(p => p.Positions != null)
                    .Where(p => p.Positions.Any(po => po.Ability >= request.Position.Ability));

            if (!string.IsNullOrWhiteSpace(request.Position.Name))
                players = players
                    .Where(p => p.Positions != null)
                    .Where(p => p.Positions.Any(po => po.Name == request.Position.Name));

            return players;
        }

        private static IEnumerable<PlayerModel> FilterOnName(SearchPlayersRequest request, IEnumerable<PlayerModel> players)
        {
            if (!string.IsNullOrWhiteSpace(request.Name))
                players = players.Where(p => p.Name.Contains(request.Name));
            return players;
        }

        private static IEnumerable<PlayerModel> FilterOnCurrentAbility(SearchPlayersRequest request, IEnumerable<PlayerModel> players)
        {
            if (request.CurrentAbility.HasValue)
                players = players.Where(p => p.CurrentAbility >= request.CurrentAbility.Value);
            return players;
        }

        private static IEnumerable<PlayerModel> FilterOnAge(SearchPlayersRequest request, IEnumerable<PlayerModel> players)
        {
            if (request.Age.HasValue)
                players = players.Where(p => p.Age <= request.Age.Value);
            return players;
        }
    }
}