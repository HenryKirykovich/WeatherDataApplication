using System;
using System.Net.Http;       // For HttpClient to make HTTP requests
using System.Windows.Forms;  // For Windows Forms UI components
using Newtonsoft.Json;       // For JSON deserialization

namespace WeatherDataApplication
{
    public partial class Form1 : Form
    {
        // Shared HttpClient instance (reused across requests to avoid socket exhaustion)
        private static readonly HttpClient client = new HttpClient();

        // Constructor: initializes form controls defined in Form1.Designer.cs
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler called when the "Get Weather" button is clicked
        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            string city = textBoxCity.Text; // Read city name from the text box
            string apiKey = "3df694e37ed7e155387463a6cc413901"; // OpenWeatherMap API key
            // Build the API URL: query by city name, use metric units (Celsius)
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                // Send GET request to the API asynchronously
                var response = await client.GetAsync(weatherUrl);
                // Throw an exception if the HTTP status code indicates failure
                response.EnsureSuccessStatusCode();

                // Read the response body as a string asynchronously
                var responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a WeatherData object
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                // Display the weather values in the corresponding labels
                labelTempValue.Text = $"{weatherData.Main.Temp} °C";
                labelHumidityValue.Text = $"{weatherData.Main.Humidity} %";
                labelWindSpeedValue.Text = $"{weatherData.Wind.Speed} m/s";
                labelDescriptionValue.Text = weatherData.Weather[0].Description;
            }
            catch (HttpRequestException ex)
            {
                // Show an error message if the API request fails
                MessageBox.Show("Error retrieving weather data: " + ex.Message);
            }
        }
    }

    // Root object that maps to the top-level JSON response from OpenWeatherMap
    public class WeatherData
    {
        public Main Main { get; set; }       // Temperature and humidity data
        public Wind Wind { get; set; }       // Wind data
        public Weather[] Weather { get; set; } // Weather condition descriptions (array)
    }

    // Maps to the "main" JSON object: temperature and humidity
    public class Main
    {
        public double Temp { get; set; }     // Temperature in Celsius
        public int Humidity { get; set; }    // Humidity in percent
    }

    // Maps to the "wind" JSON object: wind speed
    public class Wind
    {
        public double Speed { get; set; }    // Wind speed in m/s
    }

    // Maps to each item in the "weather" JSON array: sky condition description
    public class Weather
    {
        public string Description { get; set; } // e.g. "few clouds", "clear sky"
    }
}
