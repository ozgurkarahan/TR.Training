using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddOne : ComputeBase
    {
        protected override int Compute(int input)
        {
            return ++input;
        }

        protected override string FuncionName
        {
            get { return FunctionNames.ADD_ONE; }
        }
    }
}
