using MedicalInsuranceBase;
using MedicalInsuranceDll_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalInsuranceClientTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalInsuranceClient client = new MedicalInsuranceClient();
            var entity = new ClinicRegister() { RegisterID = "000" };
            var backentity = client.Handle(entity) as ClinicRegisterBack;
            MessageBox.Show($"客户端  收到实体：{backentity.RegisterID} {backentity.EntityType}");
        }
    }
}
