using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TR.Contracts
{
    public interface ICalculateCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnCalculateCallback(string functionName, int result);
    }
}
