using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_pagues
{
    public partial class Form3 : Form
    {
        public String nombre, edad, sexo, domicilio, contraseña;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(String a, String b, String c, String d, String e)
        {

            InitializeComponent();
            nombre = a;
            edad = b;
            sexo = c;
            domicilio = d;
            contraseña = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "nombres";
            dataGridView1.Columns[1].Name = "edad";
            dataGridView1.Columns[2].Name = "sexo";
            dataGridView1.Columns[3].Name = "domicilio";
            dataGridView1.Columns[4].Name = "contraseña";

            String[] row1 = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text };
            dataGridView1.Rows.Add(row1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = nombre;
            textBox2.Text = edad;
            textBox3.Text = sexo;
            textBox4.Text = domicilio;
            textBox6.Text = contraseña;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
