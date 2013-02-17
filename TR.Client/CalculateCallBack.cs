using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TR.Contracts;

namespace TR.Client
{
    /// <summary>
    /// Implementation of calculate callback contract
    /// </summary>
    public class CalculateCallBack : ICalculateCallBack
    {
        #region ICalculateCallBack Members

        public void OnCalculateCallback(string functionName, int result)
        {
            Console.WriteLine(string.Format("FunctionName: {0}, result: {1}", functionName, result));
        }

        #endregion
    }
}
