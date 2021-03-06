﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Domain.Helpers;
using Code.Domain.SearchPlayers.Models;
using Code.Presentation.WPF.ViewModels;
using NUnit.Framework;

namespace Code.Presentation.WPF.Test.ViewModels
{
    [TestFixture]
    public class SearchPlayersViewModelTests
    {
        private SearchPlayersViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new SearchPlayersViewModel();
        }

        [Test]
        public void SetPlayersRaisesItemsPropertyChanged()
        {
            var isPropertyChanged = false;
            _viewModel.PropertyChanged += (sender, e) =>
            {
                if (ExpressionHelper.GetPropertyName<SearchPlayersViewModel>(p => p.Items) == e.PropertyName)
                    isPropertyChanged = true;
            };

            _viewModel.SetPlayers(new SearchPlayersResponse());

            Assert.IsTrue(isPropertyChanged);
        }

        [Test]
        public void SetPlayersSetsItemsProperty()
        {
            var players = new List<SearchPlayerModel>();
            var response = new SearchPlayersResponse
            {
                Players = players   
            };

            _viewModel.SetPlayers(response);

            Assert.AreEqual(players, _viewModel.Items);
        }

        [Test]
        public void HeaderIsPlayers()
        {
            Assert.AreEqual("Players", _viewModel.Header);
        }
    }
}
