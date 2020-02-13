namespace SocketProject
{
    partial class FrmTcpClient
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTcpClient));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.ListRecive = new System.Windows.Forms.ListView();
            this.infoTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SendFile = new System.Windows.Forms.Button();
            this.MultiSend = new System.Windows.Forms.Button();
            this.SendJSON = new System.Windows.Forms.Button();
            this.SendHEX = new System.Windows.Forms.Button();
            this.SendUtf8 = new System.Windows.Forms.Button();
            this.SendASC = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP客户端";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtSender);
            this.splitContainer1.Panel1.Controls.Add(this.ListRecive);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SendFile);
            this.splitContainer1.Panel2.Controls.Add(this.MultiSend);
            this.splitContainer1.Panel2.Controls.Add(this.SendJSON);
            this.splitContainer1.Panel2.Controls.Add(this.SendHEX);
            this.splitContainer1.Panel2.Controls.Add(this.SendUtf8);
            this.splitContainer1.Panel2.Controls.Add(this.SendASC);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.btnStop);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtPort);
            this.splitContainer1.Panel2.Controls.Add(this.txtIP);
            this.splitContainer1.Size = new System.Drawing.Size(786, 524);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(425, 484);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(96, 27);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(3, 486);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(396, 26);
            this.txtFile.TabIndex = 2;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(0, 393);
            this.txtSender.Multiline = true;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(546, 64);
            this.txtSender.TabIndex = 1;
            // 
            // ListRecive
            // 
            this.ListRecive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.infoTime,
            this.info});
            this.ListRecive.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListRecive.HideSelection = false;
            this.ListRecive.Location = new System.Drawing.Point(0, 0);
            this.ListRecive.Margin = new System.Windows.Forms.Padding(10);
            this.ListRecive.Name = "ListRecive";
            this.ListRecive.Size = new System.Drawing.Size(546, 367);
            this.ListRecive.SmallImageList = this.imageList1;
            this.ListRecive.TabIndex = 0;
            this.ListRecive.UseCompatibleStateImageBehavior = false;
            this.ListRecive.View = System.Windows.Forms.View.Details;
            // 
            // infoTime
            // 
            this.infoTime.Text = "时间";
            this.infoTime.Width = 150;
            // 
            // info
            // 
            this.info.Text = "日志信息";
            this.info.Width = 300;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.ico");
            this.imageList1.Images.SetKeyName(1, "warning.ico");
            this.imageList1.Images.SetKeyName(2, "error.ico");
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(9, 385);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(96, 27);
            this.SendFile.TabIndex = 16;
            this.SendFile.Text = "发送文件";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // MultiSend
            // 
            this.MultiSend.Location = new System.Drawing.Point(128, 385);
            this.MultiSend.Name = "MultiSend";
            this.MultiSend.Size = new System.Drawing.Size(96, 27);
            this.MultiSend.TabIndex = 15;
            this.MultiSend.Text = "群发消息";
            this.MultiSend.UseVisualStyleBackColor = true;
            // 
            // SendJSON
            // 
            this.SendJSON.Location = new System.Drawing.Point(128, 340);
            this.SendJSON.Name = "SendJSON";
            this.SendJSON.Size = new System.Drawing.Size(96, 27);
            this.SendJSON.TabIndex = 11;
            this.SendJSON.Text = "发送JSON";
            this.SendJSON.UseVisualStyleBackColor = true;
            this.SendJSON.Click += new System.EventHandler(this.SendJSON_Click);
            // 
            // SendHEX
            // 
            this.SendHEX.Location = new System.Drawing.Point(9, 340);
            this.SendHEX.Name = "SendHEX";
            this.SendHEX.Size = new System.Drawing.Size(96, 27);
            this.SendHEX.TabIndex = 12;
            this.SendHEX.Text = "发送HEX";
            this.SendHEX.UseVisualStyleBackColor = true;
            this.SendHEX.Click += new System.EventHandler(this.SendHEX_Click);
            // 
            // SendUtf8
            // 
            this.SendUtf8.Location = new System.Drawing.Point(128, 298);
            this.SendUtf8.Name = "SendUtf8";
            this.SendUtf8.Size = new System.Drawing.Size(96, 27);
            this.SendUtf8.TabIndex = 13;
            this.SendUtf8.Text = "发送UTF8";
            this.SendUtf8.UseVisualStyleBackColor = true;
            this.SendUtf8.Click += new System.EventHandler(this.SendUtf8_Click);
            // 
            // SendASC
            // 
            this.SendASC.Location = new System.Drawing.Point(9, 298);
            this.SendASC.Name = "SendASC";
            this.SendASC.Size = new System.Drawing.Size(96, 27);
            this.SendASC.TabIndex = 14;
            this.SendASC.Text = "发送ASCII";
            this.SendASC.UseVisualStyleBackColor = true;
            this.SendASC.Click += new System.EventHandler(this.SendASC_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 97);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "在线客户端";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "连接服务";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 263);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 27);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "断开服务";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(6, 82);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(230, 26);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8001";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(3, 27);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(230, 26);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // FrmTcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTcpClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "基于Socket实现TCP客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTcpClient_FormClosing);
            this.Load += new System.EventHandler(this.FrmTcpClient_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.ListView ListRecive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ColumnHeader infoTime;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Button MultiSend;
        private System.Windows.Forms.Button SendJSON;
        private System.Windows.Forms.Button SendHEX;
        private System.Windows.Forms.Button SendUtf8;
        private System.Windows.Forms.Button SendASC;
    }
}

