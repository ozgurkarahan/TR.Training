using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddThree : ICompute
    {
        public void Compute(int input)
        {
            var result = input + 3;
            if (CallBack != null)
                CallBack("AddThree", result);
        }

        public Action<string, int> CallBack { get; set; }
    }
}
