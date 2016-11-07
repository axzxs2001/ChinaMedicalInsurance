namespace MedicalInsuranceServer
{
    partial class frmNetMessageSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP：";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(78, 24);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(184, 21);
            this.txbIP.TabIndex = 1;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(78, 57);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(184, 21);
            this.txbPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口：";
            // 
            // butSet
            // 
            this.butSet.Location = new System.Drawing.Point(227, 96);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(75, 23);
            this.butSet.TabIndex = 4;
            this.butSet.Text = "设置";
            this.butSet.UseVisualStyleBackColor = true;
            this.butSet.Click += new System.EventHandler(this.butSet_Click);
            // 
            // frmNetMessageSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 131);
            this.Controls.Add(this.butSet);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNetMessageSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP和端口设置";
            this.Load += new System.EventHandler(this.frmNetMessageSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSet;
    }
}