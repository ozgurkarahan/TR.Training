using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddFive : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 5;
        }

        public override string FuncionName
        {
            get { return "AddFive"; }
        }
    }
}
