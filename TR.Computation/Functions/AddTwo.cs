using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddTwo : ComputeBase
    {
        public override int Compute(int input)
        {
            return input + 2;
        }

        public override string FuncionName
        {
            get { return FunctionNames.ADD_TWO; }
        }
    }
}
