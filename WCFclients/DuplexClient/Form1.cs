using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace DuplexClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form ,ReportService.IReportServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessReport_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ReportService.ReportServiceClient client = new ReportService.ReportServiceClient(instanceContext);

            client.ProcessReport();
        }

        public void Progress(int percentageComplete)
        {
            textBox1.Text = percentageComplete.ToString() + " % completed";
        }
    }
}
