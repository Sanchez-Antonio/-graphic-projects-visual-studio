using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Grafica_9_puntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                //Display query
                string Query = "select * from program.edades;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            { //Accede a la columna que quieras, o las recorres todas con otro foreach...

                int valor1 = Convert.ToInt32(fila.Cells[0].Value);
                int valor2 = Convert.ToInt32(fila.Cells[1].Value);
                chart1.Series[0].Points.AddXY(valor1, valor2);
            }
        }
    }
}