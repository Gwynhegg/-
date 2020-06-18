using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Observers
{
	public delegate void ObsDelegate(object obj);

	public class StackOperationsLogger
	{
		private readonly Observer observer = new Observer();
		public void SubscribeOn<T>(ObservableStack<T> observer_stack)
		{
			observer_stack.NotifyEvent += observer.HandleEvent;
		}
		public string GetLog()
		{
			return observer.log.ToString();
		}
	}

	public class Observer
	{
		public StringBuilder log = new StringBuilder();
		public void HandleEvent(object event_data)
		{
			log.Append(event_data);
		}
	}
	public class ObservableStack<T>
	{
		List<Observer> observers_list = new List<Observer>();
		public event ObsDelegate NotifyEvent;

		List<T> data = new List<T>();

		public void Push(T obj)
		{
			data.Add(obj);
			NotifyEvent?.Invoke(new StackEventData<T> { IsPushed = true, Value = obj });

		}

		public T Pop()
		{
			if (data.Count == 0)
				throw new InvalidOperationException();
			var result = data[data.Count - 1];
			NotifyEvent?.Invoke(new StackEventData<T> { IsPushed = false, Value = result });
			return result;

		}
	}

}
