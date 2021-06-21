using System;
using System.IO;
using System.Text.Json;               // contains all entry points and main types

namespace JsonSerealization
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var weatherForecast = new WeatherForecast()
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            // This code uses synchronous code to create Json file
            var filename = "WeatherForecast.json";
            var jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(filename, jsonString);
            
            Console.WriteLine(File.ReadAllText(filename));
        }
    }
}
