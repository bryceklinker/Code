using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Code.Presentation.WPF.Selectors;
using Code.Presentation.WPF.Test.Fakes;
using Code.Presentation.WPF.Test.Fakes.ViewModels;
using Code.Presentation.WPF.Test.Fakes.Views;
using NUnit.Framework;

namespace Code.Presentation.WPF.Test.Selectors
{
    [TestFixture]
    public class ViewTemplateSelectorTests
    {
        private ViewTemplateSelector _selector;

        [SetUp]
        public void Setup()
        {
            _selector = new ViewTemplateSelector();
        }

        [Test]
        public void SelectTemplateReturnsAnEmptyTemplate()
        {
            var template = _selector.SelectTemplate(null, null);
            Assert.IsNull(template);
        }

        [Test]
        public void SelectTemplateReturnsTemplateForFakeView()
        {
            var viewModel = new FakeViewModel();
            var template = _selector.SelectTemplate(viewModel, null);

            Assert.AreEqual(typeof(FakeView), template.VisualTree.Type);
        }
    }
}
