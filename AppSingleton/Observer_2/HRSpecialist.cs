using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Observer_2
{
    public class HRSpecialist: IObserver<Application>
    {
        private IDisposable _cancellation;

        #region anterior
        public string Name { get; set; }
        public List<Application> Applications { get; set; }

        public HRSpecialist(string name)
        {
            Name = name;
            Applications = new();
        }

        public void ListApplications()
        {
            if (Applications.Any())
                foreach (Application app in Applications)
                    Console.WriteLine($"Hey, {Name}! {app.ApplicationName} has just applied for job no. {app.JobId}");
            else Console.WriteLine($"Hey, {Name}! No applications yet.");
        }
        #endregion

        public virtual void Subscribe(ApplicationsHandler provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            Applications.Clear();
        }
        public void OnCompleted()
        {
            Console.WriteLine($"Hey, {Name}! We are not accepting any more applications");
        }
        public void OnError(Exception error)
        {
            // This is called by the provider if any exception is raised, no need to implement it here
        }
        public void OnNext(Application value)
        {
            Applications.Add(value);
        }
    }
}
