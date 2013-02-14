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
            CallBack("AddThree.Compute", input + 3);
        }

        public Action<string, int> CallBack { get; set; }
    }
}
