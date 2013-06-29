using System.Collections.Generic;

namespace Code.Domain.SearchPlayers.Models
{
    public class SearchPlayersResponse
    {
        public IEnumerable<SearchPlayerModel> Players { get; set; }
    }
}