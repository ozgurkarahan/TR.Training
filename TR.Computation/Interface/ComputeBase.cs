using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Computation.Interface
{
    public abstract class ComputeBase
    {
        public void Execute(int input, Action<string, int> CallBack)
        {
            var result = this.Compute(input);
            if (CallBack != null)
                CallBack(this.FuncionName, result);
        }

        public abstract int Compute(int input);
        public abstract string FuncionName { get; }
    }
}
