using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        String nombre, edad, telefono, domicilio, correo_electronico, direccion
        public Form6(String a, String b, String c, String d, String f, String g)
        {
            InitializeComponent();
            nombre = a;
            edad = b;
            telefono = c;
            domicilio = d;
            correo_electronico = f;
            direccion = g;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = nombre;
            textBox2.Text = edad;
            textBox3.Text = telefono;
            textBox4.Text = domicilio;
            textBox5.Text = correo_electronico;
            textBox6.Text = direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  dataGridView1.Size = new Size(500, 250);
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "nombres";
            dataGridView1.Columns[1].Name = "edades";
            dataGridView1.Columns[2].Name = "telefono";
            dataGridView1.Columns[3].Name = "domicilio";
            dataGridView1.Columns[4].Name = "correo electronico";
            dataGridView1.Columns[5].Name = "direccion";
            dataGridView1.Columns[6].Name = "dinero actual";

            String[] row1 = { nombre, edad, telefono, domicilio, correo_electronico, direccion, textBox7.Text };
            dataGridView1.Rows.Add(row1);
        }
    }
}
