using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TransactionContract;

namespace TransactionManager
{
    public class TransactionResourceHost
    {
        private ServiceHost serviceHost;

        public TransactionResourceHost()
        {
            serviceHost = new ServiceHost(typeof(TransactionResourceManager));
            serviceHost.AddServiceEndpoint(typeof(ITransactionResourceManager), new NetTcpBinding(),
                new Uri("net.tcp://localhost:60000/ITransactionResourceManager"));
        }

        public void Open()
        {
            try
            {
                serviceHost.Open();
            }
            catch (Exception)
            {
                throw new Exception("Tranasaction Services can not be opened.");
            }
        }

        public void Close()
        {
            try
            {
                serviceHost.Close();
            }
            catch (Exception)
            {
                throw new Exception("Tranasaction Services can not be closed.");
            }
        }
    }
}
