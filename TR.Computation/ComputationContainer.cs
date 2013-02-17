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
        private IList<ComputeBase> _computeMethods;
        public ComputationContainer()
        {
            _computeMethods = new List<ComputeBase>();
            _computeMethods.Add(new AddOne());
            _computeMethods.Add(new AddTwo());
            _computeMethods.Add(new AddThree());
            _computeMethods.Add(new AddFour());
            _computeMethods.Add(new AddFive());
        }

        public void ComputeAll(int input, Action<string, int> callBack)
        {
            IList<Task> tasks = new List<Task>();
            foreach (var method in _computeMethods)
            {
                tasks.Add(Task.Factory.StartNew(() => method.Execute(input, callBack)));
            }
            Task.WaitAll(tasks.ToArray());
        }
    }
}
