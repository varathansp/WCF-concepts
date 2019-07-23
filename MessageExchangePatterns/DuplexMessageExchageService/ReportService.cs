using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;


namespace DuplexMessageExchageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 1; i <= 100; i++)
            {
                // some logic to process the report
                Thread.Sleep(100);
                // Get the callback channel to send messages to the client
                OperationContext.Current.GetCallbackChannel<IReportServiceCallback>().Progress(i);
            }
        }
    }
}
