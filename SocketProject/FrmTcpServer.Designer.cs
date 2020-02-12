namespace SocketProject
{
    partial class FrmTcpServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTcpServer));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.ListRecive = new System.Windows.Forms.ListView();
            this.infoTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSender = new System.Windows.Forms.Button();
            this.MultiSend = new System.Windows.Forms.Button();
            this.SendJSON = new System.Windows.Forms.Button();
            this.SendHEX = new System.Windows.Forms.Button();
            this.SendUtf8 = new System.Windows.Forms.Button();
            this.SendASC = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.OpenClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listOnline = new System.Windows.Forms.ListBox();
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
            this.label1.Text = "TCP传输服务器";
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtSender);
            this.splitContainer1.Panel1.Controls.Add(this.ListRecive);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fileSender);
            this.splitContainer1.Panel2.Controls.Add(this.MultiSend);
            this.splitContainer1.Panel2.Controls.Add(this.SendJSON);
            this.splitContainer1.Panel2.Controls.Add(this.SendHEX);
            this.splitContainer1.Panel2.Controls.Add(this.SendUtf8);
            this.splitContainer1.Panel2.Controls.Add(this.SendASC);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.OpenClient);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.listOnline);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtPort);
            this.splitContainer1.Panel2.Controls.Add(this.txtIP);
            this.splitContainer1.Size = new System.Drawing.Size(786, 524);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ListRecive.SelectedIndexChanged += new System.EventHandler(this.ListRecive_SelectedIndexChanged);
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
            // fileSender
            // 
            this.fileSender.Location = new System.Drawing.Point(9, 411);
            this.fileSender.Name = "fileSender";
            this.fileSender.Size = new System.Drawing.Size(96, 27);
            this.fileSender.TabIndex = 7;
            this.fileSender.Text = "发送文件";
            this.fileSender.UseVisualStyleBackColor = true;
            // 
            // MultiSend
            // 
            this.MultiSend.Location = new System.Drawing.Point(128, 411);
            this.MultiSend.Name = "MultiSend";
            this.MultiSend.Size = new System.Drawing.Size(96, 27);
            this.MultiSend.TabIndex = 6;
            this.MultiSend.Text = "群发消息";
            this.MultiSend.UseVisualStyleBackColor = true;
            // 
            // SendJSON
            // 
            this.SendJSON.Location = new System.Drawing.Point(128, 366);
            this.SendJSON.Name = "SendJSON";
            this.SendJSON.Size = new System.Drawing.Size(96, 27);
            this.SendJSON.TabIndex = 5;
            this.SendJSON.Text = "发送JSON";
            this.SendJSON.UseVisualStyleBackColor = true;
            // 
            // SendHEX
            // 
            this.SendHEX.Location = new System.Drawing.Point(9, 366);
            this.SendHEX.Name = "SendHEX";
            this.SendHEX.Size = new System.Drawing.Size(96, 27);
            this.SendHEX.TabIndex = 5;
            this.SendHEX.Text = "发送HEX";
            this.SendHEX.UseVisualStyleBackColor = true;
            this.SendHEX.Click += new System.EventHandler(this.SendHEX_Click);
            // 
            // SendUtf8
            // 
            this.SendUtf8.Location = new System.Drawing.Point(128, 324);
            this.SendUtf8.Name = "SendUtf8";
            this.SendUtf8.Size = new System.Drawing.Size(96, 27);
            this.SendUtf8.TabIndex = 5;
            this.SendUtf8.Text = "发送UTF8";
            this.SendUtf8.UseVisualStyleBackColor = true;
            this.SendUtf8.Click += new System.EventHandler(this.SendUtf8_Click);
            // 
            // SendASC
            // 
            this.SendASC.Location = new System.Drawing.Point(9, 324);
            this.SendASC.Name = "SendASC";
            this.SendASC.Size = new System.Drawing.Size(96, 27);
            this.SendASC.TabIndex = 5;
            this.SendASC.Text = "发送ASCII";
            this.SendASC.UseVisualStyleBackColor = true;
            this.SendASC.Click += new System.EventHandler(this.SendASC_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "启动服务";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // OpenClient
            // 
            this.OpenClient.Location = new System.Drawing.Point(128, 277);
            this.OpenClient.Name = "OpenClient";
            this.OpenClient.Size = new System.Drawing.Size(96, 27);
            this.OpenClient.TabIndex = 4;
            this.OpenClient.Text = "打开客户端";
            this.OpenClient.UseVisualStyleBackColor = true;
            this.OpenClient.Click += new System.EventHandler(this.OpenClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "在线列表";
            // 
            // listOnline
            // 
            this.listOnline.FormattingEnabled = true;
            this.listOnline.ItemHeight = 20;
            this.listOnline.Location = new System.Drawing.Point(3, 157);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(229, 104);
            this.listOnline.TabIndex = 2;
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
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(230, 26);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // FrmTcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTcpServer";
            this.Text = "基于Socket实现TCP服务器";
            this.Load += new System.EventHandler(this.FrmTcpServer_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.ListView ListRecive;
        private System.Windows.Forms.Button fileSender;
        private System.Windows.Forms.Button MultiSend;
        private System.Windows.Forms.Button SendASC;
        private System.Windows.Forms.Button OpenClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listOnline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ColumnHeader infoTime;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button SendJSON;
        private System.Windows.Forms.Button SendHEX;
        private System.Windows.Forms.Button SendUtf8;
    }
}

