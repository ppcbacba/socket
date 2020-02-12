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
                AddLog(2, "服务器开始失败 "+exception.Message);
                return;
            }
            AddLog(2,"连接服务器成功");
            

            //4.创建监听线程
            Task.Run(new Action(()=>ReceiveMessage(socketClient)));
            //

          
        }

       
        private void ReceiveMessage(Socket socket)
        {
           
            
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
                    AddLog(0, "服务器断开连接 "+e.Message);
                    break;
                }

                if (length > 0)
                {
                    //处理接收数据
                    var msg = Encoding.Default.GetString(buffer, 0, length);
                    AddLog(0, "From 服务器：" + msg);
                }
                else
                {
                    
                    AddLog(0, "服务器断开连接");
                    break;
                }

//                
            }
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
            sendMessage[0] = (byte)MessageType.ASCII;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }

        private void SendUtf8_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte)MessageType.UTF8;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }

        private void SendHEX_Click(object sender, EventArgs e)
        {
            var message = Encoding.Default.GetBytes(txtSender.Text.Trim());
            var sendMessage = new byte[message.Length + 1];
            Array.Copy(message, 0, sendMessage, 1, message.Length);
            sendMessage[0] = (byte)MessageType.Hex;
            socketClient?.Send(sendMessage);
//            txtSender.Clear();
        }
    }
}