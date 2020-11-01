using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EmployeeWCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(EmployeeWCFService.EmployeeWCFService)))
            {
                host.Open();
                Console.WriteLine("Host started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
