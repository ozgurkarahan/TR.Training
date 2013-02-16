using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TR.Contracts;

namespace TR.Client
{
    public class NamedPipeClient<T> : IClient<T>
    {
        public NamedPipeClient()
        {
            CallBack = new CalculateCallBack();
            Proxy = new DuplexChannelFactory<T>(
                                            CallBack,
                                            new NetNamedPipeBinding(),
                                            new EndpointAddress(Setting.URI));
        }

        public ICalculateCallBack CallBack { get; set; }

        public DuplexChannelFactory<T> Proxy { get; set; }
    }
}
