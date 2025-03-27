using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_ApplicationV2
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }
        
        // Initializing 
        HttpClient client = new HttpClient();
        HttpRequestMessage reqest = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
        };
        
        private async void FindWeatherBttn_Click(object sender, EventArgs e)
        {
            // vars
            string APIKey = "3f8411625ae5c9c90d059234277be095";
            string CityName = cityTextBox.Text;
            string CountryCode = countryCodeTxtBox.Text;
            string apiURI = "";
            double pressure = 0.0;
            double temperature = 0.0;

            string _apiURI = $"https://api.openweathermap.org/data/2.5/weather?q={CityName}&appid={APIKey}&units=metric";
            HttpResponseMessage response = await client.GetAsync(_apiURI);  
            
            string RealResponse = await response.Content.ReadAsStringAsync();

            dynamic weatherData = JsonConvert.DeserializeObject(RealResponse);

            temperature = weatherData["main"]["temp"];
            CityName = weatherData["name"];
            pressure = weatherData["main"]["pressure"];

            listView1.Items.Add("City: "+CityName+Environment.NewLine);
            listView1.Items.Add("Temperature: "+Convert.ToString(temperature)+Environment.NewLine);
            listView1.Items.Add("Pressure: "+Convert.ToString(pressure));    



            
        }

        private void clearBttn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                MessageBox.Show("The listbox is already empty.");
            else
            listView1.Items.Clear();
        }
    }
}
