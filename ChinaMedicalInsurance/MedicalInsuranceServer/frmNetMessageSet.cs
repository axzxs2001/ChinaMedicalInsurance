using MedicalInsuranceServer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalInsuranceServer
{
    public partial class frmNetMessageSet : Form
    {
        public frmNetMessageSet()
        {
            InitializeComponent();
        }

        private void butSet_Click(object sender, EventArgs e)
        {
            ConfigManage.WriteConfig("ip", txbIP.Text);
            ConfigManage.WriteConfig("port", txbPort.Text);
        }

        private void frmNetMessageSet_Load(object sender, EventArgs e)
        {
            txbIP.Text = ConfigManage.ReateConfig("ip");
            txbPort.Text= ConfigManage.ReateConfig("port");
        }
    }
}
