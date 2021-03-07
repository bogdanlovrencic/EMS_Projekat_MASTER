using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionContract;

namespace FTN.Services.NetworkModelService
{
    public class TransactionProvider : ITransactionContract
    {

        public bool Commit()
        {
            try
            {
                NetworkModel.actionCall?.Invoke(this, new ArgumentCaller() { Method = "Commit" });
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Prepare()
        {
            try
            {
                NetworkModel.actionCall?.Invoke(this, new ArgumentCaller() { Method = "Prepare" });
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Rollback()
        {
            try
            {
                NetworkModel.actionCall?.Invoke(this, new ArgumentCaller() { Method = "Rollback" });
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
