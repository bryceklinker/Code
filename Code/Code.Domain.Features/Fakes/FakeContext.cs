using System.Collections.Generic;
using Code.Domain.Entities.Models;
using Code.Domain.Gateways.Contexts;

namespace Code.Domain.Features.Fakes
{
    public class FakeContext : Context
    {
        private List<PlayerModel> _players;

        public void InitializePlayers(int playerCount)
        {
            _players = new List<PlayerModel>();
            for (int i = 0; i < playerCount; i++)
                AddPlayer(i);
        }

        private void AddPlayer(int current)
        {
            _players.Add(CreatePlayer(current));
        }

        private PlayerModel CreatePlayer(int current)
        {
            return new PlayerModel
            {
                CurrentAbility = current,
                Name = string.Format("name {0}", current),
                PotentialAbilty = current,
            };
        }

        public void AddPlayer(PlayerModel player)
        {
            _players.Add(player);
        }

        public IEnumerable<PlayerModel> Players
        {
            get
            {
                return _players;
            }
        }
    }
}