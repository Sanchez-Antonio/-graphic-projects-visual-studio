using MySql.Data.MySqlClient;
using System.Net.Http;
using System;
using System.Data;

namespace Encender_Leds_Http
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=1on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    DateTime fechaActual = DateTime.Today;
                    string Query = "insert into program.arduino(id_led,estado_led,nombre_led,fecha_registro) values('" + 1 + "','" + "encendido" + "','" + "led1" + "','" + fechaActual + "');";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=2on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    DateTime fechaActual = DateTime.Today;
                    string Query = "insert into program.arduino(id_led,estado_led,nombre_led,fecha_registro) values('" + 2 + "','" + "encendido" + "','" + "led2" + "','" + fechaActual + "');";
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=3on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    DateTime fechaActual = DateTime.Today;
                    string Query = "insert into program.arduino(id_led,estado_led,nombre_led,fecha_registro) values('" + 3 + "','" + "encendido" + "','" + "led3" + "','" + fechaActual + "');";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=1off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin;database=program";



                    string Query = "UPDATE arduino SET estado_led = 'apagado' WHERE id_led = 1;";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("LED state updated to 'apagado'");
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=2off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin;database=program";



                    string Query = "UPDATE arduino SET estado_led = 'apagado' WHERE id_led = 2;";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("LED state updated to 'apagado'");
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=3off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin;database=program";



                    string Query = "UPDATE arduino SET estado_led = 'apagado' WHERE id_led = 3;";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("LED state updated to 'apagado'");
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                //Display query
                string Query = "select * from program.arduino;";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}