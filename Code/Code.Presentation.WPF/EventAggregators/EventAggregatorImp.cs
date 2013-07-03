using System;
using System.Collections.Generic;
using System.Reflection;

namespace Code.Presentation.WPF.EventAggregators
{
    public class EventAggregatorImp : EventAggregator
    {
        private readonly Dictionary<Type, List<Subscriber>> _subscribers;

        public EventAggregatorImp()
        {
            _subscribers = new Dictionary<Type, List<Subscriber>>();
        }

        public void Subscribe<T>(Action<T> handler)
        {
            var subscriber = new Subscriber(handler);
            AddSubscriber<T>(subscriber);
        }

        public void Publish<T>(T args)
        {
            var subscribers = GetSubscribers<T>();
            foreach (var subscriber in subscribers)
                Publish(subscriber, args);
        }

        private void Publish<T>(Subscriber subscriber, T args)
        {
            if (subscriber.Target == null)
                return;

            var method = subscriber.Target.Method;
            var target = subscriber.Target.Target;
            var parameters = new object[]
            {
                args
            };
            method.Invoke(target, parameters);
        }

        private void AddSubscriber<T>(Subscriber subscriber)
        {
            var subscribers = GetSubscribers<T>();
            subscribers.Add(subscriber);
        }

        private List<Subscriber> GetSubscribers<T>()
        {
            if (_subscribers.ContainsKey(typeof(T)))
                return _subscribers[typeof(T)];

            var subscribers = new List<Subscriber>();
            _subscribers[typeof(T)] = subscribers;
            return subscribers;
        }

        private class Subscriber
        {
            private readonly WeakReference _target;
            private readonly MethodInfo _methodInfo;
            private readonly Type _delegateType;

            public Delegate Target
            {
                get
                {
                    return _target.Target == null
                        ? null
                        : Delegate.CreateDelegate(_delegateType, _target.Target, _methodInfo);
                }
            }

            public Subscriber(Delegate @delegate)
            {
                _target = new WeakReference(@delegate.Target);
                _methodInfo = @delegate.Method;
                _delegateType = @delegate.GetType();
            }
        }
    }
}