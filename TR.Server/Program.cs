using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

using TR.Contracts;

namespace TR.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("server is starting");
            var host = new ServiceHost(typeof(CalculateService));
            host.Open();

            Console.WriteLine("Hosting started...");
            Console.WriteLine("Press enter to exit...");
            Console.Read();
            host.Close();
        }
    }
}
