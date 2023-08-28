using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envio_Datos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String nombre, Contraseña;
        public Form2(String a, String c)
        {
            InitializeComponent();
            nombre = a;
            Contraseña = c;
            textBox1.Text = nombre;
            textBox2.Text = Contraseña;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            ((PictureBox)form.Controls["pictureBox1"]).Image = this.pictureBox1.Image;

            form.Show();
            this.Hide();
            
            


        }
    }
}
