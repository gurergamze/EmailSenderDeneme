
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace EmailSenderDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("gurerg03@gmail.com", "rnur scsl vydm czbm");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            message.To.Add(textBox1.Text);// textBox1'den alýyor burayý deðiþtir. 
            message.From = new MailAddress("gurerg03@gmail.com");
            message.Subject = textBox2.Text;
            message.Body = textBox3.Text;
            client.Send(message);
            Console.WriteLine("Mail gönderildi...");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
