using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddOne: ICompute
    {
        public void Compute(int input)
        {
            if (CallBack != null)
            {
                CallBack("AddOne.Compute", ++input);
            }
        }
       public Action<string, int> CallBack { get; set; }
    }
}
