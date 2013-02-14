using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using TR.Contracts;

namespace TR.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICallBack callBack = new CallBack();
            var pipeFactory = new DuplexChannelFactory<ICalculateService>( 
                                            callBack,
                                            new NetNamedPipeBinding(),
                                            new EndpointAddress(Setting.URI));

            ICalculateService calculateService = pipeFactory.CreateChannel();

            while (true)
            {
                string str = Console.ReadLine();
                if (str.ToLower() == "exit")
                    break;

                int input;
                if (int.TryParse(str, out input))
                {
                    calculateService.Calculate(input);
                }
                else
                {
                    Console.WriteLine("please enter a number!");
                }
            }
        }
    }
}
