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
            ICallBack callback = OperationContext.Current.GetCallbackChannel<ICallBack>();
            IComputationContainer container = new ComputationContainer();
            container.ComputeAll(input, callback.Callback);
        }

        #endregion
    }
}
