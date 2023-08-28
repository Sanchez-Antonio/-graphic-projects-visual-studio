namespace promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool EsCalificacionValida(int calificacion)
        {
            return calificacion >= 0 && calificacion <= 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox1.Text;
                string carrera = textBox2.Text;

                if (int.TryParse(textBox3.Text, out int promedio1) &&
                    int.TryParse(textBox4.Text, out int promedio2) &&
                    int.TryParse(textBox5.Text, out int promedio3))
                {
                    if (EsCalificacionValida(promedio1) && EsCalificacionValida(promedio2) && EsCalificacionValida(promedio3))
                    {
                        double promedioTotal = (promedio1 + promedio2 + promedio3) / 3.0;

                        dataGridView1.Rows.Add(nombre, carrera, promedio1, promedio2, promedio3, promedioTotal);
                    }
                    else
                    {
                        MessageBox.Show("Los valores de promedio deben ser números enteros válidos entre 0 y 10.");
                    }
                }
                else
                {
                    MessageBox.Show("Los valores de promedio deben ser números enteros válidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Carrera", "Carrera");
                dataGridView1.Columns.Add("Promedio1", "parcial_1");
                dataGridView1.Columns.Add("Promedio2", "parcial_2");
                dataGridView1.Columns.Add("Promedio3", "parcial_3");
                dataGridView1.Columns.Add("PromedioTotal", "Promedio Final");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();   // Limpia el TextBox del nombre
                textBox2.Clear();   // Limpia el TextBox de la carrera
                textBox3.Clear();   // Limpia el TextBox del promedio 1
                textBox4.Clear();   // Limpia el TextBox del promedio 2
                textBox5.Clear();   // Limpia el TextBox del promedio 3
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();   // Borra todas las filas del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
