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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        String usuario, contraseña, domicilio, color, nacimiento, edad;
        public Form3(String a, String b, String c, String d, String e, String f)
        {
            InitializeComponent();
            usuario = a;
            contraseña = b;
            domicilio = c;
            color = d;
            nacimiento = e;
            edad = f;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = usuario;
            textBox2.Text = contraseña;
            textBox3.Text = domicilio;
            textBox4.Text = color;
            textBox5.Text = nacimiento;
            textBox6.Text = edad;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "usuario";
            dataGridView1.Columns[1].Name = "contraseña";
            dataGridView1.Columns[2].Name = "domicilio";
            dataGridView1.Columns[3].Name = "color";
            dataGridView1.Columns[4].Name = "edad";
            dataGridView1.Columns[5].Name = "nacimiento";

            String[] row1 = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            dataGridView1.Rows.Add(row1);

        }
    }
}
