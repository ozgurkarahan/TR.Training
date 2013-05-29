using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using TR.Client.CalculateService;

namespace TR.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate or Type 'exit' for exit application");
            string str = Console.ReadLine();
            if (str.ToLower() == "exit")
                return;

            int input;
            if (int.TryParse(str, out input))
            {
                var callBackContract = new CalculateCallBack();
                var calculateService = new CalculateServiceClient(new InstanceContext(callBackContract));
                try
                {
                    calculateService.Calculate(input);
                }
                catch (EndpointNotFoundException)
                {
                    Console.WriteLine("Run the server before running the client!");
                }
                catch (CommunicationException)
                {
                    Console.WriteLine("An error occured during channel communication!");
                }
                finally
                {
                    var communicationObject = calculateService as ICommunicationObject;
                    if (communicationObject != null && communicationObject.State == CommunicationState.Opened)
                        communicationObject.Close();
                }
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a number!", str));
            }
        }
    }
}
