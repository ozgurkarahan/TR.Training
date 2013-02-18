using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using TR.Contracts;
using TR.Client.Binding;

namespace TR.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            IClient<ICalculateService, ICalculateCallBack> client = new NamedPipeClient();
            ICalculateService calculateService = client.Proxy.CreateChannel();

            while (true)
            {
                Console.WriteLine("Enter a number to calculate or Type 'exit' for exit application");
                string str = Console.ReadLine();
                if (str.ToLower() == "exit")
                    break;

                int input;
                if (int.TryParse(str, out input))
                {
                    try
                    {
                        calculateService.Calculate(input);
                    }
                    catch (EndpointNotFoundException)
                    {
                        Console.WriteLine("Run the server before running the client! Enter for exit");
                        Console.ReadLine();
                        break;
                    }
                    catch (CommunicationException) 
                    {
                        Console.WriteLine("An error occured during channel communication! Enter for exit");
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("please enter a number!");
                }
            }

            var communicationObject = calculateService as ICommunicationObject;
            if (communicationObject != null && communicationObject.State == CommunicationState.Opened)
                communicationObject.Close();
            
        }
    }
}
