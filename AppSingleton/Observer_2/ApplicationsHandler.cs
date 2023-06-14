using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Observer_2
{
    public class ApplicationsHandler : IObservable<Application>
    {
        private readonly List<IObserver<Application>> _observers;
        public List<Application> Applications { get; set; }
        public ApplicationsHandler() 
        {
            _observers = new();
            Applications = new();
        }

        public IDisposable Subscribe(IObserver<Application> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);

                foreach (var app in Applications)
                {
                    observer.OnNext(app);
                }
            }
            return new Unsubscriber(_observers, observer);
        }
        public void AddApplication(Application application)
        {
            Applications.Add(application);

            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }

            _observers.Clear();
        }
        public void CloseApplications()
        {
            foreach (var observer in _observers)
                observer.OnCompleted();
            _observers.Clear();
        }
    }
}
