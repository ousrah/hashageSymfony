namespace hashageSymfony
{
    using BCrypt;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string adminHash = "$2y$13$w7usfxJhm1MP8qjT8TDNzOq.UuYWFuZszfwqX/agMwG8JeqWgacZ.";
           textBox1.Text = BCrypt.Net.BCrypt.Verify("123456",adminHash).ToString();
        }
    }
}