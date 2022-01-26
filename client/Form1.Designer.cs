namespace client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnListenServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.Sky = new System.Windows.Forms.Label();
            this.txtClientSendMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPAddress";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(92, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(211, 21);
            this.txtIP.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(27, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "LocalPort";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(92, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(211, 21);
            this.txtPort.TabIndex = 3;
            // 
            // btnListenServer
            // 
            this.btnListenServer.Location = new System.Drawing.Point(350, 35);
            this.btnListenServer.Name = "btnListenServer";
            this.btnListenServer.Size = new System.Drawing.Size(76, 28);
            this.btnListenServer.TabIndex = 4;
            this.btnListenServer.Text = "Connect";
            this.btnListenServer.UseVisualStyleBackColor = true;
            this.btnListenServer.Click += new System.EventHandler(this.btnListenServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(85, 90);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(304, 162);
            this.txtMsg.TabIndex = 6;
            // 
            // Sky
            // 
            this.Sky.AutoSize = true;
            this.Sky.Location = new System.Drawing.Point(27, 293);
            this.Sky.Name = "Sky";
            this.Sky.Size = new System.Drawing.Size(47, 12);
            this.Sky.TabIndex = 8;
            this.Sky.Text = "Message";
            // 
            // txtClientSendMsg
            // 
            this.txtClientSendMsg.Location = new System.Drawing.Point(85, 290);
            this.txtClientSendMsg.Name = "txtClientSendMsg";
            this.txtClientSendMsg.Size = new System.Drawing.Size(269, 21);
            this.txtClientSendMsg.TabIndex = 9;
            this.txtClientSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientSendMsg_KeyDown_1);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(380, 288);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(65, 22);
            this.btnSendMsg.TabIndex = 10;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 372);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtClientSendMsg);
            this.Controls.Add(this.Sky);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListenServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnListenServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label Sky;
        private System.Windows.Forms.TextBox txtClientSendMsg;
        private System.Windows.Forms.Button btnSendMsg;
    }
}

