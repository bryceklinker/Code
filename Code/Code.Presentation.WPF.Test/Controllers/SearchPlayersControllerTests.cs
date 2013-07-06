using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;
using Code.Presentation.WPF.Controllers;
using Code.Presentation.WPF.EventAggregators;
using Moq;
using NUnit.Framework;

namespace Code.Presentation.WPF.Test.Controllers
{
    [TestFixture]
    public class SearchPlayersControllerTests
    {
        private Mock<SearchPlayersProducerBoundary> _mockProducerBoundary;
        private Mock<SearchPlayersConsumerBoundary> _mockConsumerBoundary;
        private EventAggregator _eventAggregator;
        private SearchPlayersController _controller;

        [SetUp]
        public void Setup()
        {
            _mockProducerBoundary = new Mock<SearchPlayersProducerBoundary>();
            _mockConsumerBoundary = new Mock<SearchPlayersConsumerBoundary>();
            _eventAggregator = new EventAggregatorImp();

            _controller = new SearchPlayersController(_eventAggregator, _mockProducerBoundary.Object, _mockConsumerBoundary.Object);
        }

        [Test]
        public void PublishingSearchPlayersRequestSendsRequestToProducerBoundary()
        {
            var request = new SearchPlayersRequest();
            _eventAggregator.Publish(request);

            _mockProducerBoundary.Verify(s => s.SearchPlayers(request, _mockConsumerBoundary.Object), Times.Once());
        }
    }
}
