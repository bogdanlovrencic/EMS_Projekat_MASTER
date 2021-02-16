using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace TransactionContract
{
    public class TransactionProxy
    {
        private readonly ITransactionResourceManager proxy;

        public TransactionProxy()
        {
            ChannelFactory<ITransactionResourceManager> channelFactory = new ChannelFactory<ITransactionResourceManager>(new NetTcpBinding()
                , new EndpointAddress("net.tcp://localhost:60000/ITransactionResourceManager"));
            proxy = channelFactory.CreateChannel();
        }

        public bool StartEnlist()
        {
            return proxy.StartEnlist();
        }

        public void Enlist()
        {
            proxy.Enlist();
        }

        public void EndEnlist(bool isSuccessful)
        {
            proxy.EndEnlist(isSuccessful);
        }

    }
}
