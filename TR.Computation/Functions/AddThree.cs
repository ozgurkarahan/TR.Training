using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddThree : ComputeBase
    {
        protected override int Compute(int input)
        {
            return input + 3;
        }

        protected override string FuncionName
        {
            get { return FunctionNames.ADD_THREE; }
        }
    }
}
