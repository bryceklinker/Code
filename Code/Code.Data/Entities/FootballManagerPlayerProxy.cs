using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Domain.Entities;
using FMEditorLive.FMObjects;
using Player = FMEditorLive.FMObjects.Player;

namespace Code.Data.Entities
{
    public class FootballManagerPlayerProxy : FootballManagerPlayer
    {
        private readonly Player _player;
        private readonly List<Position> _positions; 

        public FootballManagerPlayerProxy(Player player)
        {
            _player = player;
            _positions = new List<Position>();
            AddPositions(_player.PlayingAttribute);
        }

        private void AddPositions(PlayingAttributes playingAttributes)
        {
            _positions.Add(CreatePosition("AMC", playingAttributes.AMC));
            _positions.Add(CreatePosition("AML", playingAttributes.AML));
            _positions.Add(CreatePosition("AMR", playingAttributes.AMR));
            _positions.Add(CreatePosition("DC", playingAttributes.DC));
            _positions.Add(CreatePosition("DL", playingAttributes.DL));
            _positions.Add(CreatePosition("DM", playingAttributes.DM));
            _positions.Add(CreatePosition("DR", playingAttributes.DR));
            _positions.Add(CreatePosition("GK", playingAttributes.GK));
            _positions.Add(CreatePosition("MC", playingAttributes.MC));
            _positions.Add(CreatePosition("ML", playingAttributes.ML));
            _positions.Add(CreatePosition("MR", playingAttributes.MR));
            _positions.Add(CreatePosition("ST", playingAttributes.ST));
            _positions.Add(CreatePosition("SW", playingAttributes.SW));
            _positions.Add(CreatePosition("WBL", playingAttributes.WBL));
            _positions.Add(CreatePosition("WBR", playingAttributes.WBR));
        }

        private static Position CreatePosition(string name, sbyte ability)
        {
            return new Position
            {
                Ability = ability,
                Name = name
            };
        }

        public string FirstName
        {
            get
            {
                return _player.FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return _player.LastName;
            }
        }

        public int Age
        {
            get
            {
                return _player.Age;
            }
        }

        public int CurrentAbility
        {
            get
            {
                return _player.CurrentAbility;
            }
        }

        public int PotentialAbility
        {
            get
            {
                return _player.PotentialAbility;
            }
        }

        public IEnumerable<Position> Positions
        {
            get
            {
                return _positions;
            }
        }
    }
}
