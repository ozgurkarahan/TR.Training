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
        /// <summary>
        /// After execution of every calculation function this method will be call back
        /// with the name of the computation function and the result
        /// </summary>
        /// <param name="functionName">Computation function name that call back</param>
        /// <param name="result">Computation result of the specific compute function</param>
        [OperationContract(IsOneWay = true)]
        void OnCalculateCallback(string functionName, int result);
    }
}
