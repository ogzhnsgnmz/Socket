using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Socket.Client;

public partial class Form1 : Form
{
    private List<string> liste = new List<string>();
    private TcpListener sunucu;
    private Thread dinleyiciThread;

    public Form1()
    {
        InitializeComponent();
        StartServer();
    }

    private void StartServer()
    {
        sunucu = new TcpListener(IPAddress.Any, 12346);
        sunucu.Start();

        dinleyiciThread = new Thread(new ThreadStart(IstemcileriDinle));
        dinleyiciThread.Start();

        Log("Sunucu baþlatýldý. Ýstemciler bekleniyor...");
    }

    private void Log(string mesaj)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(Log), mesaj);
            return;
        }
        lbxLog.Items.Add(mesaj + Environment.NewLine);
    }

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

                //MesajlariIstemcilereGonder(mesaj);
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

    private void button_Click(object sender, EventArgs e)
    {
        int index = liste.IndexOf(((Button)sender).Text);

        if (index != -1)
        {
            Form2 form2 = new Form2(liste[index]);
            form2.Show();
        }
    }
    private void button1_Click(object sender, EventArgs e)
    {
        string yeniEleman = Microsoft.VisualBasic.Interaction.InputBox("Lütfen yeni elemaný girin:", "Yeni Eleman Ekle");

        if (!string.IsNullOrEmpty(yeniEleman))
        {
            liste.Add(yeniEleman);

            Button button = new Button();
            button.Text = yeniEleman;
            button.Top = liste.Count * 30+25;
            button.Left = 20;
            button.Height = 23;
            button.Width = 75;
            button.Click += button_Click;
            this.Controls.Add(button);
        }
    }
}
