using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionContract;

namespace TransactionManager
{
    public class TransactionResourceManager : ITransactionResourceManager
    {
        public void EndEnlist(bool success)
        {
            NMSProxy nMSProxy = new NMSProxy();
            bool nmsReady =   nMSProxy.Prepare();
            if(nmsReady)
            {
                nMSProxy.Commit();
            }

            Console.WriteLine("Transaction ended");
        }

        public void Enlist()
        {
            Console.WriteLine("Service joined enlist");
        }

        public bool StartEnlist()
        {
            Console.WriteLine("Started transaction");
            
            return true;
        }
    }
}
