using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TR.Client.CalculateService;

namespace TR.Client
{
    /// <summary>
    /// Implements calculate callback contracts
    /// </summary>
    public class CalculateCallBack : ICalculateServiceCallback
    {
        #region ICalculateCallBack Members

        public void OnCalculateCallback(string functionName, int result)
        {
            Console.WriteLine(string.Format("FunctionName: {0}, result: {1}", functionName, result));
            Console.WriteLine();
        }

        #endregion
    }
}
