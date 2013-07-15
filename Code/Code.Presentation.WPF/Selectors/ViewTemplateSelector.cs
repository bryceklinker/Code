using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Code.Presentation.WPF.Selectors
{
    public class ViewTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
                return base.SelectTemplate(null, container);

            var viewType = GetViewType(item);
            var dataTemplate = CreateTemplate(item.GetType(), viewType);
            return dataTemplate;
        }

        private static Type GetViewType(object item)
        {
            var viewModelType = item.GetType();
            var viewModelAssembly = viewModelType.Assembly;
            var viewTypeName = GetViewTypeName(viewModelType);
            return viewModelAssembly.GetType(viewTypeName);
        }

        private static string GetViewTypeName(Type viewModelType)
        {
            return viewModelType.FullName
                .Replace("ViewModels", "Views")
                .Replace("ViewModel", "View");
        }

        private static DataTemplate CreateTemplate(Type viewModelType, Type viewType)
        {
            var dataTemplate = new DataTemplate
            {
                DataType = viewModelType
            };
            var elementFactory = new FrameworkElementFactory(viewType);
            dataTemplate.VisualTree = elementFactory;
            return dataTemplate;
        }
    }
}
