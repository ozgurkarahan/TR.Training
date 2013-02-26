using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddFour : ComputeBase
    {
        protected override int Compute(int input)
        {
            return input + 4;
        }

        protected override string FuncionName
        {
            get { return FunctionNames.ADD_FOUR; }
        }
    }
}
