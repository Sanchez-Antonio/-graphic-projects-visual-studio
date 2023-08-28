using System.Windows.Forms;

namespace E_1
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

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form2 form2 = new Form2(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form2.Show();
            this.Hide();
            ((PictureBox)form2.Controls["pictureBox1"]).Image = this.pictureBox1.Image;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form3 form2 = new Form3(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form4 form2 = new Form4(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form5 form = new Form5(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form6 form2 = new Form6(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String edad = textBox2.Text;
            String telefono = textBox3.Text;
            String domicilio = textBox4.Text;
            String corre_electronico = textBox5.Text;
            String direccion = textBox6.Text;

            Form7 form2 = new Form7(nombre, edad, telefono, domicilio, corre_electronico, direccion);
            form2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("La casilla de verificación está marcada.");
            }
            else
            {
                MessageBox.Show("La casilla de verificación está desmarcada.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("El botón de opción 1 está seleccionado.");
            }
        }
    }
}