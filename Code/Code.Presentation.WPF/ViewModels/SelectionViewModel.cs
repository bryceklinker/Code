using System.Collections;

namespace Code.Presentation.WPF.ViewModels
{
    public interface SelectionViewModel
    {
        string Header { get; }
        IEnumerable Items { get; }
    }
}