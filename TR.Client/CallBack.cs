﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TR.Contracts;

namespace TR.Client
{
    public class CallBack : ICallBack
    {
        #region ICallBack Members

        public void Callback(string functionName, int result)
        {
            Console.WriteLine(string.Format("FunctionName: {0}, result: {1}", functionName, result));
        }

        #endregion
    }
}
