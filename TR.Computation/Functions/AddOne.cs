using TR.Computation.Base;

namespace TR.Computation.Functions
{
    public class AddOne : ComputeBase
    {
        public override int Compute(int input)
        {
            return ++input;
        }

        public override string FuncionName
        {
            get { return FunctionNames.ADD_ONE; }
        }
    }
}
