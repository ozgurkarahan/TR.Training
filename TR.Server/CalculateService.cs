using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using TR.Contracts;
using TR.Computation;

namespace TR.Server
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class CalculateService : ICalculateService
    {
        #region ICalculateService Members

        public void Calculate(int input)
        {
            ICalculateCallBack callback = OperationContext.Current.GetCallbackChannel<ICalculateCallBack>();
            IComputationContainer container = new ComputationContainer();
            try
            {
                container.ComputeAll(input, callback.OnCalculateCallback);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine(ex.InnerException.Message);
            }
        }

        #endregion
    }
}
