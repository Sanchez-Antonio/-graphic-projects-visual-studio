namespace File_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try

            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    string imagen = openFileDialog1.FileName;

                    pictureBox1.Image = Image.FromFile(imagen);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}