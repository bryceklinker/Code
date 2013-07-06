using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.SearchPlayers.Boundaries
{
    public interface SearchPlayersProducerBoundary
    {
        void SearchPlayers(SearchPlayersRequest request, SearchPlayersConsumerBoundary consumerBoundary);
    }
}