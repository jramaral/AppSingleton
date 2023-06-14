using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Observer
{
    public class Subject
    {
        public delegate void EventHandler(string message);
        public event EventHandler Notify;

        public void Change(string message)
        {
            Notify?.Invoke(message);
        }
    }
}
