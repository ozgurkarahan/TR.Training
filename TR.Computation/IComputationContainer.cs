using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TR.Computation
{
    public interface IComputationContainer
    {
        void ComputeAll(int input, Action<string, int> callBack);
    }
}
