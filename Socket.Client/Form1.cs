namespace Socket.Client;

public partial class Form1 : Form
{
    private List<string> liste = new List<string>();

    public Form1()
    {
        InitializeComponent();
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
