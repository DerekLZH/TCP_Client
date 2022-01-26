using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        Socket socketClient = null;
        Thread threadClient = null;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListenServer_Click(object sender, EventArgs e)
        {
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddress = IPAddress.Parse(this.txtIP.Text.Trim());
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(this.txtPort.Text.Trim()));

            try
            {
                socketClient.Connect(endpoint);
                this.txtMsg.AppendText("connect successfully!" + "\r\n");
                this.btnListenServer.Enabled=false;
                threadClient=new Thread(RecMsg);
                threadClient.IsBackground=true;
                threadClient.Start();

            }
            catch(Exception ex){
                this.txtMsg.AppendText("cannot access to the Server!"+"\r\n");

            }
        }
        private void RecMsg()
        {
            while (true)
            {
                try
                {
                    byte[] arrRecMsg = new byte[1024 * 1024];
                    int length = socketClient.Receive(arrRecMsg);
                    string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                    txtMsg.AppendText("Server"+"\t" + GetCurrentTime() + "\r\n" + strRecMsg + "\r\n");
                }
                catch (Exception ex)
                {
                    this.txtMsg.AppendText("disconnected!" + "\r\n");
                    this.btnListenServer.Enabled = true;
                    break;

                }
            }
        }

        private void ClientSendMsg(String sendMsg)
        {
            try
            {
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                socketClient.Send(arrClientSendMsg);
                txtMsg.AppendText("Client"+"\t" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");

            }
            catch (Exception ex)
            {
                this.txtMsg.AppendText("disconnected!"+"\r\n");

            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            ClientSendMsg(this.txtClientSendMsg.Text.Trim());
            this.txtClientSendMsg.Clear();
        }

  
        private DateTime GetCurrentTime()
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            return datetime;
        }

        private void txtClientSendMsg_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //则调用客户端向服务端发送信息的方法
                ClientSendMsg(this.txtClientSendMsg.Text.Trim());
                this.txtClientSendMsg.Clear();
            }
        }

     
    }
}
