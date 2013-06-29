using Code.Domain.Entities;

namespace Code.Domain.SearchPlayers.Models
{
    public class SearchPlayersRequest
    {
        public int? CurrentAbility { get; set; }
        public int? PotentialAbility { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int? Age { get; set; }
    }
}