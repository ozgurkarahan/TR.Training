using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddTwo : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 2;
        }

        public override string FuncionName
        {
            get { return "AddTwo"; }
        }
    }
}
