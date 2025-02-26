using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        
        public int listenPort;
        public int writePort;
        public UdpClient udpCl = new UdpClient();
        public IPAddress serverIP;
        public StreamWriter fileWrite;
        Code code = new Code();
        public Form1()
        {
            using (StreamReader file = new StreamReader("connnection.txt"))
            {
                serverIP = IPAddress.Parse(file.ReadLine());
                listenPort = Int16.Parse(file.ReadLine());
                writePort = Int16.Parse(file.ReadLine());
            }
            InitializeComponent();
            using (fileWrite = new StreamWriter(DateTime.Now.ToString().Replace(' ','_')+".txt", false))
            {
                GetMessage();
            }
        }
        public async void GetMessage()
        {
            using (UdpClient udpServer = new UdpClient(listenPort))
            {
                string res;
                while (true)
                {
                    var result = await udpServer.ReceiveAsync();
                    res = code.StrDecode(Encoding.UTF8.GetString(result.Buffer));
                    richTextBox1.Text += res + "\n";
                    fileWrite.WriteLine(res);
                }
            }
        }
        public async void SendMessage(string str)
        {  
            byte[] data = Encoding.UTF8.GetBytes(code.StrCode(str));
            IPEndPoint remotePoint = new IPEndPoint(serverIP, writePort);
            int bytes = await udpCl.SendAsync(data, remotePoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage(textBox1.Text);
        }
    }
}
