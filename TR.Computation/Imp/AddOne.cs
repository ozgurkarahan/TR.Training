using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddOne : ICompute
    {
        public void Compute(int input)
        {
            var result = ++input;
            if (CallBack != null)
                CallBack("AddOne", result);
        }

        public Action<string, int> CallBack { get; set; }
    }
}
