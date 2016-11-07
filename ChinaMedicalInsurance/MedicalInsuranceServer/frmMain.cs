using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using MedicalInsuranceBase;
using MedicalInsuranceServer.Common;

namespace MedicalInsuranceServer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = ConfigManage.ReateConfig("title");
        }


        private MedicalInsuranceBase.MedicalInsuranceEntity Server_SendEnvent(MedicalInsuranceBase.MedicalInsuranceEntity entity)
        {
            var content = $"{DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒")}  {entity.EntityType}";
            Log(content, Color.Red);
            //加载当前目录中的医保操作类
            var curPath = AppDomain.CurrentDomain.BaseDirectory;
            var dllOperation = CommonHandle.GetDllOperation(curPath);
            if (dllOperation == null)
            {
                MessageBox.Show($"在{curPath}下找不到实现IDllOperation的子类！", "Dll加载错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new NullEntity();
            }
            else
            {
                return dllOperation.Operation(entity);
            }
        }

        void Log(string content, Color color)
        {
            if (lvLog.Items.Count > 100)
            {
                lvLog.Items.RemoveAt(99);
            }
            lvLog.Items.Insert(0, new ListViewItem() { ForeColor = color, Text = content });

        }

    

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //实例化医保服务端
            var server = new MedicalInsuranceBase.MedicalInsuranceServer();
            server.AcceptEntity += Server_SendEnvent;
            server.Start();

        }



        private void iPPortSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmIpPort = new frmNetMessageSet();
            frmIpPort.ShowDialog();
        }
    }


}



