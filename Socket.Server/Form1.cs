using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Socket.Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartServer();
            StartClient();
        }

        private void StartServer()
        {
            sunucu = new TcpListener(IPAddress.Any, 12346);
            sunucu.Start();

            dinleyiciThread = new Thread(new ThreadStart(IstemcileriDinle));
            dinleyiciThread.Start();

            Log("Sunucu baþlatýldý. Ýstemciler bekleniyor...");
        }

        private void StartClient()
        {
            try
            {
                istemci = new TcpClient();
                istemci.Connect("127.0.0.1", 12345);
                akim = istemci.GetStream();
                Log("Sunucuya baðlandý.");
                string mesaj = "127.0.0.1:12345";
                byte[] gonderiVerisi = Encoding.UTF8.GetBytes(mesaj);
                akim.Write(gonderiVerisi, 0, gonderiVerisi.Length);
                Log("Sunucuya gönderildi: " + mesaj);
            }
            catch (Exception ex)
            {
                Log("Hata: " + ex.Message);
            }
        }

        private TcpListener sunucu;
        private Thread dinleyiciThread;

        private TcpClient istemci;
        private NetworkStream akim;

        private void IstemcileriDinle()
        {
            try
            {
                while (true)
                {
                    TcpClient istemci = sunucu.AcceptTcpClient();
                    Thread istemciThread = new Thread(new ParameterizedThreadStart(IstemciyiIsle));
                    istemciThread.Start(istemci);
                }
            }
            catch (Exception ex)
            {
                Log("Hata: " + ex.Message);
            }
        }

        private void IstemciyiIsle(object istemciObj)
        {
            TcpClient istemci = (TcpClient)istemciObj;
            NetworkStream akim = istemci.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = akim.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string mesaj = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Log("Ýstemciden alýndý: " + mesaj);

                    MesajlariIstemcilereGonder(mesaj);
                }
            }
            catch (Exception ex)
            {
                Log("Ýstemci iþlenirken hata oluþtu: " + ex.Message);
            }
            finally
            {
                istemci.Close();
            }
        }

        private void MesajlariIstemcilereGonder(string mesaj)
        {

        }

        private void Log(string mesaj)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(Log), mesaj);
                return;
            }
            lbxLog.Items.Add(mesaj);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

        }
    }
}
