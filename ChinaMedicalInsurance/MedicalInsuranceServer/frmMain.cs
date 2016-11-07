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

            var dllOperation = GetDllOperation(AppDomain.CurrentDomain.BaseDirectory);
            if (dllOperation == null)
            {
                MessageBox.Show($"在{AppDomain.CurrentDomain.BaseDirectory}下找不到实现IDllOperation的子类！", "Dll加载错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// 反射得到实现IDllOperation的类型
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        IDllOperation GetDllOperation(string dir)
        {
            foreach (var file in System.IO.Directory.GetFiles(dir))
            {
                if (Path.GetExtension(file).ToUpper() == ".DLL")
                {
                    //加载程序集
                    var assembly = Assembly.LoadFile(file);
                    foreach (var type in assembly.GetTypes())
                    {
                        //判断是从IDllOperation继承的子类
                        if (!type.IsInterface && !type.IsAbstract && type.GetInterface("IDllOperation") != null)
                        {
                            return Activator.CreateInstance(type) as IDllOperation;

                        }
                    }
                }
            }
            foreach (var subdir in System.IO.Directory.GetDirectories(dir))
            {
                return GetDllOperation(subdir);
            }
            return null;
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



