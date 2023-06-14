using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Observer
{
    public class Observer
    {
        private string name;
        public Observer(string name, Subject subject)
        {
            this.name = name;
            subject.Notify += Update;
            
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }
}
