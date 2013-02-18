using System;

namespace TR.Computation
{
    public interface IComputationContainer
    {
        void ComputeAll(int input, Action<string, int> callBack);
    }
}
