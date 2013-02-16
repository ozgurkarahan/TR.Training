using System;
namespace TR.Client
{
    interface IClient<T>
    {
        TR.Contracts.ICalculateCallBack CallBack { get; set; }
        System.ServiceModel.DuplexChannelFactory<T> Proxy { get; set; }
    }
}
