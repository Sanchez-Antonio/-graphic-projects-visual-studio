using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace login_pagues
{
    public partial class Form2 : Form
    {

        public String nombre, contraseña, edad, sexo, domicilio;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String c, String d)
        {
            InitializeComponent();
            nombre = c;
            contraseña = d;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            if (checkBox1.Checked)
            {
                a = 30;
            }
            else
            {
                a = 25;
            }

            if (radioButton1.Checked)
            {
                b = 30;
            }
            else
            {
                b = 25;
            }

            int operacion = a * b / 3;






            String Resultado;


            Resultado = "\r\nnombre " + textBox1.Text + "\r\nedad " + textBox2.Text + "\r\nsexo " + textBox3.Text + "\r\ndomicilio" + textBox4.Text + "\r\nel resultado de los datos multiplicados y divididos fue " + operacion + "\r\nla contraseña es " + contraseña + "\r\nel usuario es " + nombre;

            textBox5.Text = Resultado;






        }

        private void Form2_Load(object sender, EventArgs e)
        {

            textBox1.Text = nombre;
            textBox6.Text = contraseña;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            edad = textBox2.Text;
            sexo = textBox3.Text;
            domicilio = textBox4.Text;

            Form3 form3 = new Form3(nombre, edad, sexo, domicilio, contraseña);
            form3.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

