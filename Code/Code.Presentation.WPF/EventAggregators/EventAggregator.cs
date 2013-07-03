using System;

namespace Code.Presentation.WPF.EventAggregators
{
    public interface EventAggregator
    {
        void Subscribe<T>(Action<T> handler);
        void Publish<T>(T args);
    }
}