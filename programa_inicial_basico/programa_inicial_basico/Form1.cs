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
            int edad, a�os_cotizados, a�os_sin_cotizar, curp, rfc;
            double resultado;
            String final;
            edad = int.Parse(textBox6.Text);
            a�os_cotizados = int.Parse(textBox7.Text);
            a�os_sin_cotizar = int.Parse(textBox8.Text);
            resultado = (a�os_cotizados - a�os_sin_cotizar) * 0.8 * edad;
            textBox9.Text = resultado.ToString();
            curp = int.Parse(textBox4.Text);
            rfc = int.Parse(textBox5.Text);
            textBox10.Text = "la edad es -->" + edad.ToString() + "\r\nlos a�os cotizados son -->\r\n" + a�os_cotizados.ToString()
                + "\r\nlos a�os sin cotizar son -->" + a�os_sin_cotizar.ToString() + "\r\nla couta mensual es -->" + resultado.ToString() + "\r\nrfc es -->" + rfc.ToString() + "\r\nla curp es -->" + curp.ToString();

        }
    }
}