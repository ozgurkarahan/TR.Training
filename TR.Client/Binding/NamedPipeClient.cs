using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TR.Contracts;

namespace TR.Client.Binding
{
    public class NamedPipeClient : IClient<ICalculateService, ICalculateCallBack>
    {
        public NamedPipeClient()
        {
            CallBackContract = new CalculateCallBack();
            Proxy = new DuplexChannelFactory<ICalculateService>(
                                            CallBackContract,
                                            new NetNamedPipeBinding(),
                                            new EndpointAddress(Setting.PipeUri));
        }

        public ICalculateCallBack CallBackContract { get; set; }

        public DuplexChannelFactory<ICalculateService> Proxy { get; set; }
    }
}
