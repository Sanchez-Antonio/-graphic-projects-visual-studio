namespace db_practica_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert form = new insert();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete form = new delete();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            update form = new update();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show form = new show();
            form.Show();
            this.Hide();
        }
    }
}