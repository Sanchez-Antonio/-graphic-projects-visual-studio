namespace programa_inicial_basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad, años_cotizados, años_sin_cotizar, curp, rfc;
            double resultado;
            String final;
            edad = int.Parse(textBox6.Text);
            años_cotizados = int.Parse(textBox7.Text);
            años_sin_cotizar = int.Parse(textBox8.Text);
            resultado = (años_cotizados - años_sin_cotizar) * 0.8 * edad;
            textBox9.Text = resultado.ToString();
            curp = int.Parse(textBox4.Text);
            rfc = int.Parse(textBox5.Text);
            textBox10.Text = "la edad es -->" + edad.ToString() + "\r\nlos años cotizados son -->\r\n" + años_cotizados.ToString()
                + "\r\nlos años sin cotizar son -->" + años_sin_cotizar.ToString() + "\r\nla couta mensual es -->" + resultado.ToString() + "\r\nrfc es -->" + rfc.ToString() + "\r\nla curp es -->" + curp.ToString();

        }
    }
}