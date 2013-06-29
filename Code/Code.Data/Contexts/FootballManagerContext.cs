using System.Collections.Generic;
using System.Linq;
using Code.Data.Games;
using Code.Domain.Entities.Models;
using Code.Domain.Gateways.Contexts;

namespace Code.Data.Contexts
{
    public class FootballManagerContext : Context
    {
        private readonly FootballManagerGame _game;

        public FootballManagerContext(FootballManagerGame game)
        {
            _game = game;
            _game.Load();
        }

        public IEnumerable<PlayerModel> Players
        {
            get
            {
                return _game.Players.Select(p => new PlayerModel());
            }
        }
    }
}