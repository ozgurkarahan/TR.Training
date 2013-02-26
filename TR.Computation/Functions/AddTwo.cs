using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddTwo : ComputeBase
    {
        protected override int Compute(int input)
        {
            return input + 2;
        }

        protected override string FuncionName
        {
            get { return FunctionNames.ADD_TWO; }
        }
    }
}
