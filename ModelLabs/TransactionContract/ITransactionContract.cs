using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TransactionContract
{
    [ServiceContract]
    public interface ITransactionContract
    {
        [OperationContract]
        bool Commit();

        [OperationContract]
        bool Rollback();

        [OperationContract]
        UpdateResult Prepare();        
    }
}
