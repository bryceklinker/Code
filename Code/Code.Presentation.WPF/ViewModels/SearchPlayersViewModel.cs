using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Code.Domain.Helpers;
using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;

namespace Code.Presentation.WPF.ViewModels
{
    public class SearchPlayersViewModel : SearchPlayersConsumerBoundary, INotifyPropertyChanged
    {
        public IEnumerable<SearchPlayerModel> Players { get; private set; }

        public void SetPlayers(SearchPlayersResponse playersResponse)
        {
            Players = playersResponse.Players;
            RaisePropertyChanged(() => Players);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePopertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            RaisePopertyChanged(propertyExpression.GetPropertyName());
        }
    }
}