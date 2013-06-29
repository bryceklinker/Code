using System.Collections.Generic;
using Code.Domain.Entities;
using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.Gateways
{
    public interface PlayerGateway
    {
        IEnumerable<Player> GetPlayers(SearchPlayersRequest request);
    }
}