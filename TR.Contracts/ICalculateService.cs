using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TR.Contracts
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallBack))]
    public interface ICalculateService
    {
        [OperationContract]
        void Calculate(int input);
    }
}
