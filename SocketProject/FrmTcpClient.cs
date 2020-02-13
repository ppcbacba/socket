using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProject
{
    public partial class FrmTcpClient : Form
    {
        public FrmTcpClient()
        {
            InitializeComponent();
        }

        /*
         *1 create socket=new socket(Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
         *2 socket binding(ipe)
         *3 socket listen
         * 4 socketclient=socket.accept  new socket用来接收数据
         * 4 socketclient=socket.accept  new socket用来接收数据
         * 4 socketclient=socket.accept  new socket用来接收数据
         * 5 length=socketClient.receive(buffer) 
         *
         */

        //创建字典集合 clientIP:socketClient
        private Dictionary<string, Socket> CurrentClientList = new Dictionary<string, Socket>();


        //声明一个socket对象
        private Socket socketClient;
        private string server;
        private log4net.ILog log = log4net.LogManager.GetLogger("Server.Logging");

        private void btnStart_Click(object sender, EventArgs e)
        {
            //1.create a socket
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            AddLog(0, "开始初始化socket");
            //2.binding ip and port;
            try
            {
                socketClient.Connect(new IPEndPoint(IPAddress.Parse(this.txtIP.Text), int.Parse(txtPort.Text.Trim())));
            }
            catch (Exception exception)
            {
                //p写入日志
                AddLog(2, "服务器开始失败 " + exception.Message);
                return;
            }

            AddLog(2, "连接服务器成功");


            //4.创建监听线程
            Task.Run(new Action(() => ReceiveMessage(socketClient)));
            //
        }


        private void ReceiveMessage(Socket socket)
        {
            string msg;
            server = txtIP.Text.Trim() + ":" + txtPort.Text.Trim();


            //5 处理客户端连接请求
            while (true)
            {
                var buffer = new byte[1024 * 1024 * 2]; //缓冲区大小
                var length = -1;
                try
                {
                    //Receive方法：接收数据到buffer,并返回数据长度。buffer是byte[].
                    length = socketClient.Receive(buffer);
                }
                catch (Exception e)
                {
                    AddLog(0, "服务器断开连接 " + e.Message);
                    break;
                }

                if (length > 0)
                {
                    //处理接收数据
                    var type = (MessageType) buffer[0];
                    switch (type)
                    {
                        case MessageType.ASCII:
                            msg = Encoding.ASCII.GetString(buffer, 1, length - 1);
                            AddLog(0, server + ": " + msg);
                            break;
                        case MessageType.UTF8:
                            msg = Encoding.UTF8.GetString(buffer, 1, length - 1);
                            AddLog(0, server + ": " + msg);
                            break;
                        case MessageType.Hex:
                            msg = HexGetString(buffer, 1, length - 1);
                            AddLog(0, server + ": " + msg);

                            break;
                        case MessageType.File:
                            Invoke(new Action(() =>
                            {
                                var sfd = new SaveFileDialog();
                                sfd.Filter =
                                    "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|xlsx files(*.xlsx)|*.xlsx|All files(*.*)|*.*";
                                if (sfd.ShowDialog() == DialogResult.OK)
                                {
                                    var fileSavePath = sfd.FileName;
                                    using (var fs = new FileStream(fileSavePath, FileMode.Create))
                                    {
                                        fs.Write(buffer, 1, length - 1);
                                    }

                                    AddLog(0, "文件保存成功：" + fileSavePath);
                                }
                            }));
                            break;
                        case MessageType.JSON:
                            Invoke(new Action(() =>
                            {
                                var res = Encoding.Default.GetString(buffer, 1, length);
                                var stuList = JSONHelper.JSONToEntity<List<Student>>(res);
                                new FrmJson(stuList).Show();
                                AddLog(0, "接收JSON对象" + res);
                            }));
                            break;
                    }
                }
                else
                {
                    AddLog(0, "服务器断开连接");
                    break;
                }

//                
            }
        }

        private string HexGetString(byte[] buffer, int start, int length)
        {
            var result = string.Empty;
            if (buffer != null && buffer.Length >= start + length)
            {
                var res = new byte[length];
                Array.Copy(buffer, start, res, 0, length);
                var Hex = Encoding.Default.GetString(res, 0, res.Length);
                if (Hex.Contains(" "))
                {
                    var str = Regex.Split(Hex, "\\s+", RegexOptions.IgnoreCase);
                    foreach (var s in str)
                    {
                        result += "0x" + s + "";
                    }
                }
                else
                {
                    result += "0x" + Hex;
                }
            }
            else result = "Error";

            return result;
        }

        private void FrmTcpClient_Load(object sender, EventArgs e)
        {
            this.ListRecive.Columns[1].Width = this.ListRecive.ClientSize.Width - this.ListRecive.Columns[0].Width;
        }

        private string CurrentTime => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //接收信息的方法
        private void AddLog(int index, string info)
        {
            Invoke(new Action(() =>
            {
                var lst = new ListViewItem(" " + CurrentTime, index);
                lst.SubItems.Add(info);
                var count = ListRecive.Items.Count;
                ListRecive.Items.Add(lst);
                ListRecive.TopItem = lst;
            }));
            log.Info(info);
        }

        /// <summary>
        /// 在线列表更新
        /// </summary>
        /// <param name="client"></param>
        /// <param name="operation">true：add.false:rmmove</param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            socketClient.Close();
            ;
        }


        private void FrmTcpClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketClient.Close();
        }

        private void SendASC_Click(object sender, EventArgs e)
        {
            var message = Encoding.ASCII.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.ASCII;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }

        private void SendUtf8_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.UTF8;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }

        private void SendHEX_Click(object sender, EventArgs e)
        {
            var message = Encoding.Default.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.Hex;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFile.Text = ofd.FileName;
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("先选择要发送的文件");
            }
            else
            {
                using (var fs = new FileStream(txtFile.Text, FileMode.Open))
                {
                    var Filename = Path.GetFileName(txtFile.Text);
                    var fileExtension = Path.GetExtension(txtFile.Text);
                    var strMsg = "发送文件:" + Filename + "." + fileExtension;
                    var send1 = Encoding.Default.GetBytes(strMsg);
                    var send1Msg = new byte[send1.Length + 1];
                    Array.Copy(send1, 0, send1Msg, 1, send1.Length);
                    send1Msg[0] = (byte) MessageType.UTF8;
                    socketClient?.Send(send1Msg);

                    var send2 = new byte[1024 * 1024 * 10];
                    var length = fs.Read(send2, 0, send2.Length);
                    var send2Msg = new byte[length + 1];
                    Array.Copy(send2, 0, send2Msg, 1, length);
                    send2Msg[0] = (byte) MessageType.File;
                    socketClient?.Send(send2Msg);
                }
            }
        }

        private void SendJSON_Click(object sender, EventArgs e)
        {
            var StuList = new List<Student>()
            {
                new Student() {Id = 10001, StudentName = "张三", ClassName = "软件一班"},
                new Student() {Id = 10002, StudentName = "李梅", ClassName = "软件二班"},
                new Student() {Id = 10003, StudentName = "张雷", ClassName = "软件一班"},
                new Student() {Id = 10004, StudentName = "汪洋", ClassName = "网络一班"}
            };
            var str = JSONHelper.EntityToJSON(StuList);
            var send = Encoding.Default.GetBytes(str);
            var sendMsg = new byte[send.Length + 1];
            Array.Copy(send, 0, sendMsg, 1, send.Length);
            sendMsg[0] = (byte) MessageType.JSON;
            socketClient.Send(sendMsg);
        }
    }
}