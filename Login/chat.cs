using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChattingProgram
{
    public partial class chat : Form
    {
        public NetworkStream m_Stream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        const int PORT = 2002;
        private Thread m_ThReader;

        public bool m_bStop = false;

        private TcpListener m_listener;
        private Thread m_thServer;

        public bool m_bConnect = false;
        TcpClient m_Client;

        public chat()
        {
            InitializeComponent();
        }

        public void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txtAll.AppendText(msg + "\r\n");

                txtAll.Focus();
                txtAll.ScrollToCaret();

                txtSend.Focus();
            }));
        }

        public void ServerStart()
        {
            try
            {
                m_listener = new TcpListener(PORT);
                m_listener.Start();

                m_bStop = true;
                Message("클라이언트 접속 대기중");

                while (m_bStop)
                {
                    TcpClient hClient = m_listener.AcceptTcpClient();

                    if (hClient.Connected)
                    {
                        m_bConnect = true;
                        Message("클라이언트 접속");

                        m_Stream = hClient.GetStream();
                        m_Read = new StreamReader(m_Stream);
                        m_Write = new StreamWriter(m_Stream);

                        m_ThReader = new Thread(new ThreadStart(Receive));
                        m_ThReader.Start();
                    }
                }
            }
            catch
            {
                Message("시작 도중에 오류 발생");
                return;
            }
        }

        public void ServerStop()
        {
            if (!m_bStop)
                return;

            m_listener.Stop();

            m_Read.Close();
            m_Write.Close();

            m_Stream.Close();

            m_ThReader.Abort();
            m_thServer.Abort();

            Message("서비스 종료");
        }

        public void Disconnect()
        {

        }

        public void Connect()
        {

        }

        public void Receive()
        {
            try
            {
                while (m_bConnect)
                {
                    string szMessage = m_Read.ReadLine();

                    if (szMessage != null)
                        Message("상대방 >>> : " + szMessage);
                }    
            }
            catch
            {
                Message("데이터를 읽는 과정에서 오류가 발생");
            }
            Disconnect();
        }

        public void Send()
        {
            try
            {
                m_Write.WriteLine(txtSend.Text);
                m_Write.Flush();

                Message(">>> : " + txtSend.Text);
                txtSend.Text = "";
            }
            catch
            {
                Message("데이터 전송 실패");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 친구 목록 불러오기
            LoadFriendsFromServer();
        }

        private void LoadFriendsFromServer()
        {
            // 서버에서 친구 목록을 가져오는 코드 작성
            // 가져온 친구 목록을 lstFriend에 추가
            
        }
    }
}
