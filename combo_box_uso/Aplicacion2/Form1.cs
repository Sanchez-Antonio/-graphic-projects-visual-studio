namespace Aplicacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("antonio");
            comboBox1.Items.Add("alexis");
            comboBox1.Items.Add("jonny");
            comboBox1.Items.Add("ramón");
            comboBox1.Items.Add("luis");
            comboBox1.Items.Add("oscar");
            comboBox1.Items.Add("pedro");
            comboBox1.Items.Add("roberto");
            comboBox1.Items.Add("juan");
            comboBox1.Items.Add("esmeralda");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text.ToString());
            MessageBox.Show("OBJETO ELIMINADO CON EXITO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           comboBox1.Items.Remove(textBox2.Text.ToString());



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}