using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informacion_tablas
{
    public partial class Form2 : Form
    {
        public String mensaje;

        public Form2()

        {
            InitializeComponent();
        }
        public Form2(String texto)
        {
            InitializeComponent();
            mensaje = texto;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  dataGridView1.Size = new Size(500, 250);
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "nombres";
            dataGridView1.Columns[1].Name = "telefono";
            dataGridView1.Columns[2].Name = "Domicilio";
            dataGridView1.Columns[3].Name = "FECHA";
            dataGridView1.Columns[4].Name = "APELLIDO";

            String[] row1 = { "antonio", "21313", "guerrero", "2023/32/34", "sanchez" };
            dataGridView1.Rows.Add(row1);
            String[] row2 = { "alexis", "21313", "guerrero", "2023/32/34", "sanchez" };
            dataGridView1.Rows.Add(row2);
            String[] row3 = { "juan", "21313", "guerrero", "2023/32/34", "sanchez" };
            dataGridView1.Rows.Add(row3);
            String[] row4 = { "jonny", "21313", "guerrero", "2023/32/34", "sanchez" };
            dataGridView1.Rows.Add(row4);
            String[] row5 = { "ramon", "21313", "guerrero", "2023/32/34", "sanchez" };
            dataGridView1.Rows.Add(row5);
        }
    }
}
