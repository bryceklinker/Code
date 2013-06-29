using System.Collections.Generic;
using Code.Data.Entities;

namespace Code.Data.Games
{
    public interface FootballManagerGame
    {
        void Load();
        IEnumerable<FootballManagerPlayer> Players { get; }
    }
}