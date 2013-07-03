using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Presentation.WPF.EventAggregators;
using Code.Presentation.WPF.ViewModels;
using Moq;
using NUnit.Framework;

namespace Code.Presentation.WPF.Test.ViewModels
{
    [TestFixture]
    public class MainViewModelTests
    {
        private MainViewModel _viewModel;
        private EventAggregator _eventAggregator;

        [SetUp]
        public void Setup()
        {
            _eventAggregator = new EventAggregatorImp();
            _viewModel = new MainViewModel(_eventAggregator);
        }

        [Test]
        public void PublishSelectionViewModelAddsViewModel()
        {
            var mockSelectionView = new Mock<SelectionViewModel>();

            _eventAggregator.Publish(mockSelectionView.Object);
            Assert.IsTrue(_viewModel.SelectionViewModels.Contains(mockSelectionView.Object));
        }

        [Test]
        public void PublishContentViewModelAddsViewModel()
        {
            var mockContentView = new Mock<ContentViewModel>();

            _eventAggregator.Publish(mockContentView.Object);
            Assert.IsTrue(_viewModel.ContentViewModels.Contains(mockContentView.Object));
        }
    }
}
