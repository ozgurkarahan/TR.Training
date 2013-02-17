using System;
namespace TR.Client
{
    /// <summary>
    /// Client interface to create a duplex channel with a callback contract
    /// </summary>
    /// <typeparam name="T">Service Contract</typeparam>
    /// <typeparam name="K">Callback Contract</typeparam>
    interface IClient<T,K>
    {
        K CallBackContract { get; set; }

        System.ServiceModel.DuplexChannelFactory<T> Proxy { get; set; }
    }
}
