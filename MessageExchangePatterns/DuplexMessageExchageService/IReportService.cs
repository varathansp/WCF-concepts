using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexMessageExchageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]
    public interface IReportService
    {
        // Since we have not set IsOnway=true, the operation is Request/Reply operation
        [OperationContract]
        void ProcessReport();
    }

    // This is the callback contract
    public interface IReportServiceCallback
    {
        // Since we have not set IsOnway=true, the operation is Request/Reply operation
        [OperationContract]
        void Progress(int percentageComplete);
    }
}
