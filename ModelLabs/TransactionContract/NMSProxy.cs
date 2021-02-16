using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using FTN.Common;

namespace TransactionContract
{
    public class NMSProxy
    {
        private readonly ITransactionContract proxy;

        public NMSProxy()
        {
            ChannelFactory<ITransactionContract> channelFactory = new ChannelFactory<ITransactionContract>(new NetTcpBinding(),
                new EndpointAddress("net.tcp://localhost:10001/NetworkModelService/Transaction"));
            proxy = channelFactory.CreateChannel();
        }

        public bool Commit()
        {
            return proxy.Commit();
        }

        public bool Prepare()
        {
            return proxy.Prepare();
        }

        public bool Rollback()
        {
            return proxy.Rollback();
        }
    }
}
