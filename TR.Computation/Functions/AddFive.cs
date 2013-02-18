using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddFive : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 5;
        }

        public override string FuncionName
        {
            get { return FunctionNames.ADD_FIVE; }
        }
    }
}
