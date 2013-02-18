using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddFour : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 4;
        }

        public override string FuncionName
        {
            get { return FunctionNames.ADD_FOUR; }
        }
    }
}
