using Code.Presentation.WPF.EventAggregators;
using NUnit.Framework;

namespace Code.Presentation.WPF.Test.EventAggregators
{
    [TestFixture]
    public class EventAggregatorImpTests
    {
        private EventAggregatorImp _aggregator;

        [SetUp]
        public void Setup()
        {
            _aggregator = new EventAggregatorImp();
        }

        [Test]
        public void PublishSendsArgsToAllSubscribers()
        {
            var firstSubscriber = false;
            var secondSubscriber = false;

            _aggregator.Subscribe<object>(a => firstSubscriber = true);
            _aggregator.Subscribe<object>(a => secondSubscriber = true);

            _aggregator.Publish(new object());

            Assert.IsTrue(firstSubscriber);
            Assert.IsTrue(secondSubscriber);
        }

        [Test]
        public void PublishWithNoSubscibersDoesNotThrowException()
        {
            _aggregator.Publish(new object());
        }
    }
}