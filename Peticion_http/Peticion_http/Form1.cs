using System.Net.Http;
namespace Peticion_http
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=on";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                MessageBox.Show(response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync().Result : $"La solicitud falló con el código de estado: {response.StatusCode}");
            }
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://192.168.4.22/?led=off";
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                MessageBox.Show(response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync().Result : $"La solicitud falló con el código de estado: {response.StatusCode}");
            }
        }
    }
}