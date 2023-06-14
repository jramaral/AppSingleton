using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Observer_2
{
    public class Application
    {
        public int JobId { get; set; }
        public string ApplicationName { get; set; }

        public Application(int jobId, string applicationName)
        {
            JobId = jobId;
            ApplicationName = applicationName;
        }
    }
}
