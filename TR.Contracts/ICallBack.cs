using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TR.Contracts
{
    public interface ICallBack
    {
        [OperationContract(IsOneWay = true)]
        void Callback(string functionName, int result);
    }
}
