using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Weather_ApplicationV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        } 

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string RealUsername = "Harpy";
            string RealPassword = "A1TaskForce";

            if (textBox1.Text == RealUsername)
            {
                if (textBox2.Text == RealPassword)
                {
                    MessageBox.Show("Welcome, " + RealUsername);
                    mainF f1 = new mainF(); // Opens the main user interface after conditions are met 
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect password.");
                }
            }
            else
            {
                MessageBox.Show("Invalid user.");
            }

            // Will add error exception later

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            /*
            try
            {

                HttpResponseMessage response = await http_client.GetAsync(http://api.openweathermap.org/geo/1.0/direct?q=city name&limit=limit&appid=3f8411625ae5c9c90d059234277be095)

                    // Checking if request was successful 
                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content as string 
                        string weatherData = await 
                        response.Content.ReadAsStringAsync();

                        // Display weather data in a textbox 
                        textBox3.Text= weatherData;
                    }
                    else 
                    {
                        // Display error message if request was not successful 
                        textBox3.Text = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    }
            }
            catch (Exception ex) 
            {
                //  Display message if an error occurs 
                textBox3.Text = $"Error: {ex.Message}";
            }
            */ 
        }
    }
}
