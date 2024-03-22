using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Socket.Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sunucu = new TcpListener(IPAddress.Any, 12345);
            sunucu.Start();

            dinleyiciThread = new Thread(new ThreadStart(IstemcileriDinle));
            dinleyiciThread.Start();

            Log("Sunucu baþlatýldý. Ýstemciler bekleniyor...");
        }

        private TcpListener sunucu;
        private Thread dinleyiciThread;

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
