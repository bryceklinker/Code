using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;

namespace Code.Domain.Features.SearchPlayers.Fakes
{
    public class FakeSearchPlayersConsumerBoundary : SearchPlayersConsumerBoundary
    {
        public SearchPlayersResponse Response { get; private set; }

        public void SetPlayers(SearchPlayersResponse playersResponse)
        {
            Response = playersResponse;
        }
    }
}