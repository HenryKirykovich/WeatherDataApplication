# Weather Data Application

A Windows Forms desktop application that fetches and displays real-time weather data for any city using the [OpenWeatherMap API](https://openweathermap.org/api).

## Features

- Enter any city name and retrieve current weather instantly
- Displays temperature (°C), humidity (%), wind speed (m/s), and sky condition
- Asynchronous HTTP requests — UI stays responsive while fetching data
- JSON response parsed with Newtonsoft.Json

## Technologies

- C# / .NET Framework 4.7.2
- Windows Forms
- `System.Net.Http.HttpClient`
- [Newtonsoft.Json 13.0.4](https://www.nuget.org/packages/Newtonsoft.Json/)
- [OpenWeatherMap Current Weather API](https://openweathermap.org/current)

## Setup

1. Clone the repository and open `WeatherDataApplication.slnx` in Visual Studio.
2. Register at [openweathermap.org](https://openweathermap.org) to get a free API key.
3. In `Form1.cs`, replace the `apiKey` value with your own key:
   ```csharp
   string apiKey = "YOUR_API_KEY_HERE";
   ```
4. Build and run the project (`F5`).

## Usage

1. Type a city name in the text box (e.g. `London`, `Seattle`, `Tokyo`).
2. Click **Get Weather**.
3. Temperature, humidity, wind speed, and description will be displayed.

## Project Structure

```
WeatherDataApplication/
├── Form1.cs              # Main form logic and API call
├── Form1.Designer.cs     # Auto-generated UI layout
├── Program.cs            # Application entry point
└── packages.config       # NuGet package references
```
