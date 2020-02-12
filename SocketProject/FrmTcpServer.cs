using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProject
{
    public enum MessageType
    {
        ASCII,
        UTF8,
        Hex,
        File,
        JSON
    }

    public partial class FrmTcpServer : Form
    {
        public FrmTcpServer()
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
        private Socket socketServer;
        private Socket socketClient;
        private log4net.ILog log = log4net.LogManager.GetLogger("Server.Logging");

        private void btnStart_Click(object sender, EventArgs e)
        {
            //1.create a socket
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            log.Info(": 开始初始化socket");
            AddLog(0, "开始初始化socket");
            //2.binding ip and port;
            try
            {
                socketServer.Bind(new IPEndPoint(IPAddress.Parse(this.txtIP.Text), int.Parse(txtPort.Text.Trim())));
            }
            catch (Exception exception)
            {
                //p写入日志
                AddLog(2, "服务器开始失败 " + exception.Message);
                return;
            }

            //3.监听
            try
            {
                socketServer.Listen(10); //虽然是10个，但是服务器一旦accept，缓冲资源又
                AddLog(0, "开启监听");
            }
            catch (Exception exception)
            {
                AddLog(0, "监听启动错误" + exception.Message);
                return;
            }


            //4.创建监听线程
            Task.Run(CheckedList);

            btnStart.Enabled = false;
            SendASC.Enabled = true;
            OpenClient.Enabled = true;
            MultiSend.Enabled = true;
            fileSender.Enabled = true;
        }

        /// <summary>
        /// 监听方法体
        /// </summary>
        private void CheckedList()
        {
            while (true)
            {
                //Accept 从侦听套接字的连接请求队列中同步提取第一个挂起的连接请求，然后创建并返回新的 Socket。 不能使用返回的 Socket 接受来自连接队列的任何其他连接。 但是，你可以调用返回的 Socket 的 RemoteEndPoint 方法来识别远程主机的网络地址和端口号
                try
                {
                    socketClient = socketServer.Accept();
                    var client = socketClient.RemoteEndPoint.ToString();

                    //
                    CurrentClientList.Add(client, socketClient);

                    UpdateOnline(client, true);
                    AddLog(1, client + " 上线");

                    //开户接收线程
                    Task.Run(() => ReceiveMessage(socketClient));
                }
                catch (Exception e)
                {
                    AddLog(0, "accept错误 " + e.Message);
                    return;
                }

                //更新连接列表
            }
        }

        private void ReceiveMessage(Socket socket)
        {
            var buffer = new byte[1024 * 1024 * 2]; //缓冲区大小
            var length = -1;
            var client = socketClient.RemoteEndPoint.ToString();
            string msg;
            //5 处理客户端连接请求
            while (true)
            {
                try
                {
                    //Receive方法：接收数据到buffer,并返回数据长度。buffer是byte[].
                    length = socketClient.Receive(buffer);
                }
                catch (Exception e)
                {
                    UpdateOnline(client, false);
                    AddLog(0, client + "下线" + e.Message);
                    CurrentClientList.Remove(client);
                    break;
                }

                if (length > 0)
                {
                    var type = (MessageType) buffer[0];
                    switch (type)
                    {
                        case MessageType.ASCII:
                            msg = Encoding.ASCII.GetString(buffer, 1, length - 1);
                            AddLog(0, client + ": " + msg);
                            break;
                        case MessageType.UTF8:
                            msg = Encoding.UTF8.GetString(buffer, 1, length - 1);
                            AddLog(0, client + ": " + msg);
                            break;
                        case MessageType.Hex:
                            msg = HexGetString(buffer, 1, length - 1);
                            AddLog(0,client+": "+msg);

                            break;
                    }
                }
                else
                {
                    UpdateOnline(client, false);
                    CurrentClientList.Remove(client);
                    AddLog(0, client + "下线");
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

        private void ListRecive_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmTcpServer_Load(object sender, EventArgs e)
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
        private void UpdateOnline(string client, bool operation)
        {
            Invoke(new Action(() =>
            {
                if (operation)
                {
                    listOnline.Items.Add(client);
                }
                else
                {
                    foreach (var item in listOnline.Items)
                    {
                        if (item.ToString() == client)
                        {
                            listOnline.Items.Remove(item);
                            break;
                        }
                    }
                }
            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            socketServer.Close();
            OpenClient.Enabled = false;
            btnStart.Enabled = true;
            SendASC.Enabled = false;
            MultiSend.Enabled = false;
            fileSender.Enabled = false;
        }

        private void SendASC_Click(object sender, EventArgs e)
        {
            var message = Encoding.ASCII.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.ASCII;
            socketClient?.Send(sendMessage);
            txtSender.Clear();
        }


        private void OpenClient_Click(object sender, EventArgs e)
        {
            new FrmTcpClient().Show();
        }

        private void SendUtf8_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.UTF8;
            socketClient?.Send(sendMessage);
            txtSender.Clear();
        }

        private void SendHEX_Click(object sender, EventArgs e)
        {
            var message = Encoding.Default.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte) MessageType.Hex;
            socketClient?.Send(sendMessage);
            txtSender.Clear();
        }
    }
}