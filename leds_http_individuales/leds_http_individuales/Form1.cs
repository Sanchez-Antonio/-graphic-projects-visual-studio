using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace leds_http_individuales
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                //Display query
                string Query = "select * from program.log_arduino;";
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
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led1=on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my update query in which i am taking input from the user through windows forms and update the record.
                    string Query = "UPDATE program.log_arduino SET led1='ENCENDIDO', encendidos=encendidos+1 WHERE id=1;";

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here
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


                string url = "http://192.168.4.22/?led1=off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my update query in which i am taking input from the user through windows forms and update the record.
                    string Query = "UPDATE program.log_arduino SET led1='APAGADO', apagados=apagados+1 WHERE id=1;";
                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here
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
                string url = "http://192.168.4.22/?led2=on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "UPDATE program.log_arduino SET led2='ENCENDIDO', encendidos=encendidos+1 WHERE id=2;";
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

        private void button5_Click(object sender, EventArgs e)
        {

            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led2=off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "UPDATE program.log_arduino SET led2='APAGADO', apagados=apagados+1 WHERE id=2;";
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
                string url = "http://192.168.4.22/?led3=on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "UPDATE program.log_arduino SET led3='ENCENDIDO', encendidos=encendidos+1 WHERE id=3;";
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

        private void button6_Click(object sender, EventArgs e)
        {

            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led3=off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                try
                {
                    //This is my connection string i have assigned the database file address path
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                    //This is my insert query in which i am taking input from the user through windows forms
                    string Query = "UPDATE program.log_arduino SET led3='APAGADO', apagados=apagados+1 WHERE id=3;";
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=admin";
                string Query = "delete from program.log_arduino;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
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

        private void button9_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                int encendidos = Convert.ToInt32(fila.Cells["encendidos"].Value);
                int apagados = Convert.ToInt32(fila.Cells["apagados"].Value);

                chart1.Series[0].Points.AddXY("Encendidos", encendidos);
                chart1.Series[0].Points.AddXY("Apagados", apagados);
            }



        }



    }
    }
    