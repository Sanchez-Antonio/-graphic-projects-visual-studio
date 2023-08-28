using System;

namespace login_pagues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "antonio":
                    if (textBox2.Text.Equals("admin"))
                    {

                        Form2 form = new Form2(textBox1.Text,textBox2.Text);
                        form.Show();
                        this.Hide();
                        MessageBox.Show("USUARIO INGRESADO CORRECTAMENTE ");

                    }
                    else {
                        MessageBox.Show("invalido ");
                    }
                    break;
                case "juan":
                    if (textBox2.Text.Equals("admin2"))
                    {

                        Form2 form = new Form2();
                        form.Show();
                        MessageBox.Show("USUARIO INGRESADO CORRECTAMENTE ");

                    }
                    else
                    {
                        MessageBox.Show("invalido ");
                    }
                    break;
                case "roberto":

                    if (textBox2.Text.Equals("admin3"))
                    {

                        Form2 form = new Form2();
                        form.Show();
                        MessageBox.Show("USUARIO INGRESADO CORRECTAMENTE ");

                    }
                    else
                    {
                        MessageBox.Show("invalido ");
                    }

                    break;
                case "alexis":

                    if (textBox2.Text.Equals("admin4"))
                    {

                        Form2 form = new Form2();
                        form.Show();
                        MessageBox.Show("USUARIO INGRESADO CORRECTAMENTE ");

                    }
                    else
                    {
                        MessageBox.Show("invalido ");
                    }

                    break;
                case "ramon":

                    if (textBox2.Text.Equals("admin5"))
                    {

                        Form2 form = new Form2();
                        form.Show();
                        MessageBox.Show("USUARIO INGRESADO CORRECTAMENTE ");

                    }
                    else
                    {
                        MessageBox.Show("invalido ");
                    }

                    break;
                default:
                    MessageBox.Show("USUARIO INVALIDO INTENTA DE NUEVO ");
                    break;
            }







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}