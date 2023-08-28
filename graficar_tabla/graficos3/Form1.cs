using MySql.Data.MySqlClient;
using System.Data;

namespace graficos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  chart1.Series[0].Points.AddXY(5, 5);
            //chart1.Series[0].Points.AddXY(10, 7);
            //chart1.Series["Grafica"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            { //Accede a la columna que quieras, o las recorres todas con otro foreach...

                int valor1 = Convert.ToInt32(fila.Cells[0].Value);
                int valor2 = Convert.ToInt32(fila.Cells[1].Value);
                chart1.Series[0].Points.AddXY(valor1, valor2);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                //Display query
                string Query = "select * from program.numeros;";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}