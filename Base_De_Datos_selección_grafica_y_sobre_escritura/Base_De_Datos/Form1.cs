using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace Base_De_Datos;



public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into program.clientes(Nombre,Apellido,Fecha_Nacimiento,Direccion) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {


        try
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
            //Display query
            string Query = "select * from program.clientes;";
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
            MessageBox.Show(ex.Message);
        }




    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}


