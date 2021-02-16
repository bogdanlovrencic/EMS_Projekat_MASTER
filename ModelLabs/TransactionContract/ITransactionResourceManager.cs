using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace TransactionContract
{
    [ServiceContract]
    public interface ITransactionResourceManager
    {
        [OperationContract]
        bool StartEnlist();

        [OperationContract]
        void Enlist();

        [OperationContract]
        void EndEnlist(bool success);
    }
}
