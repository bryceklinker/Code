using System.Collections.Generic;

namespace Code.Domain.Entities.Models
{
    public class PlayerModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int PotentialAbilty { get; set; }
        public int CurrentAbility { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}