using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddFour : ICompute
    {
        #region ICompute Members

        public void Compute(int input)
        {
            var result = input + 4;
            if (CallBack != null)
                CallBack("Addfour", result);
        }

        public Action<string, int> CallBack { get; set; }

        #endregion
    }
}
