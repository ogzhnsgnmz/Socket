using System.Net.Sockets;
using System.Text;

namespace Socket.Client;

public partial class Form2 : Form
{
    public Form2(string secilenEleman)
    {
        InitializeComponent();
    }
    private TcpClient istemci;
    private NetworkStream akim;

    private void Log(string mesaj)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(Log), mesaj);
            return;
        }
        lbxLog.Items.Add(mesaj + Environment.NewLine);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            string mesaj = MesajTextBox.Text;
            byte[] gonderiVerisi = Encoding.UTF8.GetBytes(mesaj);
            akim.Write(gonderiVerisi, 0, gonderiVerisi.Length);
            Log("Sunucuya gönderildi: " + mesaj);
        }
        catch (Exception ex)
        {
            Log("Hata: " + ex.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            istemci = new TcpClient();
            istemci.Connect(IpTextBox.Text, Convert.ToInt32(PortTextBox.Text));
            //istemci.Connect("127.0.0.1", 12345);
            akim = istemci.GetStream();

            Log("Sunucuya bağlandı.");

            IpTextBox.Enabled = false;
            PortTextBox.Enabled = false;
            button2.Visible = false;
            button1.Enabled = true;
        }
        catch (Exception ex)
        {
            Log("Hata: " + ex.Message);
        }
    }
}
