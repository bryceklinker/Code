using System.Collections.Generic;
using Code.Domain.Entities;

namespace Code.Domain.SearchPlayers.Models
{
    public class SearchPlayerModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public int CurrentAbility { get; set; }
        public int PotentialAbility { get; set; }
    }
}