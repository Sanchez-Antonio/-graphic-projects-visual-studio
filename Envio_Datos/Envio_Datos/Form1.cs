namespace Envio_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                Form2 form = new Form2(textBox1.Text, textBox2.Text);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NO SE INGRESO UN USUARIO CORRECTO");
            }


        }


    }
}
