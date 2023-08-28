
using MySql.Data.MySqlClient;

namespace Conexion_db
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
        public class bd
        {
            public static void obtener_conexion() {
               
                var builder = new MySqlConnectionStringBuilder { Server = "127.0.0.1", UserID = "root", Password = "admin", Database = "program", };
                 
                // open a connection asynchronously using
                var connection = new MySqlConnection(builder.ConnectionString);
                // await
                 connection.OpenAsync();

                using var command = connection.CreateCommand(); command.CommandText = @"SELECT * FROM Clientes WHERE idCliente = 1;"; 
                command.Parameters.AddWithValue("@OrderId", orderId);
                // execute the command and read the results
                 using var reader = command.ExecuteReaderAsync();
                while (reader.WaitAsync())
                {
                    var id = reader.GetInt32("order_id");
                    var date = reader.GetDateTime("order_date");
                }

                connection.CloseAsync();
              

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bd.obtener_conexion();
            MessageBox.Show("CONECTADO");

        }
    }
}