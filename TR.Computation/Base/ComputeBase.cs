using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Computation.Base
{
    public abstract class ComputeBase
    {
        protected ComputeBase()
        {

        }

        public void Execute(int input, Action<string, int> CallBack)
        {
            var result = this.Compute(input);
            if (CallBack != null)
                CallBack(this.FuncionName, result);
        }

        protected abstract int Compute(int input);
        protected abstract string FuncionName { get; }
    }
}
