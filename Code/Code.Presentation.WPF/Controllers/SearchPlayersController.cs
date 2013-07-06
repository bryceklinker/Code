using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;
using Code.Presentation.WPF.EventAggregators;

namespace Code.Presentation.WPF.Controllers
{
    public class SearchPlayersController
    {
        private readonly EventAggregator _eventAggregator;
        private readonly SearchPlayersProducerBoundary _producerBoundary;
        private readonly SearchPlayersConsumerBoundary _consumerBoundary;

        public SearchPlayersController(EventAggregator eventAggregator, SearchPlayersProducerBoundary producerBoundary, SearchPlayersConsumerBoundary consumerBoundary)
        {
            _eventAggregator = eventAggregator;
            _producerBoundary = producerBoundary;
            _consumerBoundary = consumerBoundary;

            _eventAggregator.Subscribe<SearchPlayersRequest>(HandleSearchPlayersRequest);
        }

        private void HandleSearchPlayersRequest(SearchPlayersRequest request)
        {
            _producerBoundary.SearchPlayers(request, _consumerBoundary);
        }
    }
}