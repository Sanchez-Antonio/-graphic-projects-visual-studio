using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_actividad
{
    public partial class animals : Form
    {
        public animals()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text1;

            text1 = "nombre " + textBox1.Text + "\r\ncorreo de tutor  " + textBox2.Text + "\r\ncolor " + textBox3.Text + "\r\nedad " + textBox4.Text + "\r\nsexo " + textBox5.Text;

            textBox6.Text = text1;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            familiar form3 = new familiar();
            form3.Show();
        }
    }
}
