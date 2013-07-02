using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code.Domain.Helpers;
using NUnit.Framework;

namespace Code.Domain.Test.Helpers
{
    [TestFixture]
    public class ExpressionHelperTests
    {
        [Test]
        public void GetPropertyNameReturnsText()
        {
            var propertyName = ExpressionHelper.GetPropertyName<FakeClass>(p => p.Text);
            Assert.AreEqual("Text", propertyName);
        }

        [Test]
        public void GetPropertyNameReturnsTextUsingExtension()
        {
            var propertyName = new FakeClass().GetTextName();
            Assert.AreEqual("Text", propertyName);
        }

        private class FakeClass
        {
            public string Text { get; set; }

            public string GetTextName()
            {
                return GetTextName(() => Text);
            }

            private string GetTextName<T>(Expression<Func<T>> property)
            {
                return property.GetPropertyName();
            }
        }
    }
}
