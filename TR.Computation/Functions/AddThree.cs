using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddThree : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 3;
        }

        public override string FuncionName
        {
            get { return FunctionNames.ADD_THREE; }
        }
    }
}
