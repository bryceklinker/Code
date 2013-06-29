using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Code.Data.Entities;
using FMEditorLive.FMObjects;

namespace Code.Data.Games
{
    public class FootballManagerGameImp : FootballManagerGame
    {
        public void Load()
        {
            MainProcess.LoadGame(new ProgressBar());
        }

        public IEnumerable<FootballManagerPlayer> Players
        {
            get
            {
                return MainProcess.Persons
                    .Where(p => p.Type == PersonType.Player)
                    .Select(Player.FromPerson)
                    .Select(p => new FootballManagerPlayerProxy(p))
                    .ToArray();
            }
        }
    }
}