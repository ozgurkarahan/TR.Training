using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddFive : ComputeBase
    {
        protected override int Compute(int input)
        {
            return input + 5;
        }

        protected override string FuncionName
        {
            get { return FunctionNames.ADD_FIVE; }
        }
    }
}
