using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Computation.Interface
{
    public interface ICompute
    {
        void Compute(int input);
        Action<string, int> CallBack { get; set; }
    }
}
