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

            var binding = new NetNamedPipeBinding();
            var host = new ServiceHost(typeof(CalculateService), new Uri(Setting.URI));
            host.AddServiceEndpoint(typeof(ICalculateService), binding, "");
            host.Open();

            Console.WriteLine("Hosting started...");
            Console.Read();
        }
    }
}
