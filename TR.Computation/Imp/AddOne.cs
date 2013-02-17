using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddOne : ComputeBase
    {
        public override int Compute(int input)
        {
            return ++input;
        }

        public override string FuncionName
        {
            get { return "AddOne"; }
        }
    }
}
