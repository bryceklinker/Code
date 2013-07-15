using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Code.Domain.Helpers;
using Code.Domain.SearchPlayers.Boundaries;
using Code.Domain.SearchPlayers.Models;

namespace Code.Presentation.WPF.ViewModels
{
    public class SearchPlayersViewModel : ViewModelBase, SearchPlayersConsumerBoundary, SelectionViewModel
    {
        private const string HeaderText = "Players";

        public IEnumerable Items { get; private set; }

        public string Header
        {
            get
            {
                return HeaderText;
            }
        }

        public void SetPlayers(SearchPlayersResponse playersResponse)
        {
            Items = playersResponse.Players;
            RaisePropertyChanged(() => Items);
        }
    }
}