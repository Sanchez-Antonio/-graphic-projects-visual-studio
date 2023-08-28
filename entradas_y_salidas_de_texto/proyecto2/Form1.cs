namespace proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado;
            resultado = "nombres: " + textBox3.Text + "\r\n apellido paterno: " + textBox2.Text + "\r\n apellido materno: " + textBox1.Text;
            textBox4.Text = resultado;
        }
    }
}