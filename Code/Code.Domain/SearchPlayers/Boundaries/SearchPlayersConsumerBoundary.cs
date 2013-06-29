using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.SearchPlayers.Boundaries
{
    public interface SearchPlayersConsumerBoundary
    {
        void SetPlayers(SearchPlayersResponse playersResponse);
    }
}