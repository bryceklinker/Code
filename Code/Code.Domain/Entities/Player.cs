using System.Collections.Generic;
using System.Linq;
using Code.Domain.Entities.Models;

namespace Code.Domain.Entities
{
    public class Player
    {
        private readonly int _age;
        private readonly string _name;
        private readonly int _potentialAbility;
        private readonly int _currentAbility;
        private readonly List<Position> _positions;

        public static Player CreatePlayer(PlayerModel model)
        {
            return new Player(model);
        }

        private Player(PlayerModel model)
        {
            _age = model.Age;
            _name = model.Name;
            _currentAbility = model.CurrentAbility;
            _potentialAbility = model.PotentialAbilty;
            _positions = ConvertPositions(model);
        }

        private static List<Position> ConvertPositions(PlayerModel model)
        {
            return model.Positions == null
                ? null
                : Enumerable.Select<Position, Position>(model.Positions, p => new Position
                {
                    Ability = p.Ability,
                    Name = p.Name
                }).ToList();
        }

        public string GetName()
        {
            return _name;
        }

        public int GetPotential()
        {
            return _potentialAbility;
        }

        public int GetAbility()
        {
            return _currentAbility;
        }

        public IEnumerable<Position> GetPositions()
        {
            return _positions;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}