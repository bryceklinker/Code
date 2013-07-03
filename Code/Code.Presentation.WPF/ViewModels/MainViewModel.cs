using System.Collections.Generic;
using System.Collections.ObjectModel;
using Code.Presentation.WPF.EventAggregators;

namespace Code.Presentation.WPF.ViewModels
{
    public class MainViewModel
    {
        private readonly EventAggregator _eventAggregator;
        private readonly ObservableCollection<SelectionViewModel> _selectionViewModels;
        private readonly ObservableCollection<ContentViewModel> _contentViewModels;

        public IEnumerable<SelectionViewModel> SelectionViewModels
        {
            get
            {
                return _selectionViewModels;
            }
        }

        public IEnumerable<ContentViewModel> ContentViewModels
        {
            get
            {
                return _contentViewModels;
            }
        }

        public MainViewModel(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe<SelectionViewModel>(HandleSelectionViewAdded);
            _eventAggregator.Subscribe<ContentViewModel>(HandleContentViewModelAdded);

            _selectionViewModels = new ObservableCollection<SelectionViewModel>();
            _contentViewModels = new ObservableCollection<ContentViewModel>();
        }

        private void HandleSelectionViewAdded(SelectionViewModel selectionView)
        {
            _selectionViewModels.Add(selectionView);
        }

        private void HandleContentViewModelAdded(ContentViewModel contentViewModel)
        {
            _contentViewModels.Add(contentViewModel);
        }
    }
}