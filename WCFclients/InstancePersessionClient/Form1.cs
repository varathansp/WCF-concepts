using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstancePersessionClient
{
    public partial class Form1 : Form
    {
        SimpleService.SimpleServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SimpleService.SimpleServiceClient();  
        }
       
        private void btnIncrement_Click(object sender, EventArgs e)
        {
           
            try
            {
                MessageBox.Show("Number = " + client.IncrementNumber().ToString() + "Session ID : " + client.InnerChannel.SessionId);
            }
            catch (System.ServiceModel.CommunicationException)
            {
                if (client.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    MessageBox.Show("Session timed out. Your existing session will be lost. A new session will now be created");
                    client = new SimpleService.SimpleServiceClient();
                }
            }
        }
    }
}
