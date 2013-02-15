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
            _computeMethods.Add(new AddFour());
            _computeMethods.Add(new AddFive());
        }

        public void ComputeAll(int input, Action<string, int> callBack)
        {
            foreach (var method in _computeMethods)
            {
                method.CallBack = callBack;
                Task.Factory.StartNew(() => method.Compute(input));
            }
        }
    }
}
