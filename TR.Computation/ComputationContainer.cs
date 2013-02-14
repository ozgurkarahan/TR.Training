using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Imp;
using TR.Computation.Interface;

namespace TR.Computation
{
    public class ComputationContainer : IComputationContainer
    {
        private IList<ICompute> _computeMethods;
        public ComputationContainer()
        {
            _computeMethods = new List<ICompute>();
            _computeMethods.Add(new AddOne());
            _computeMethods.Add(new AddTwo());
            _computeMethods.Add(new AddThree());
        }

        public void ComputeAll(int input, Action<string, int> callBack)
        {
            foreach (var compute in _computeMethods)
            {
                compute.CallBack = callBack;
                compute.Compute(input);
            }
        }
    }
}
