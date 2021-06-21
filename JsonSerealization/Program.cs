using System;
using System.IO;
using System.Text.Json;               // contains all entry points and main types
using System.Threading.Tasks;

namespace JsonSerealization
{
    class Program
    {
        static async Task Main(string[] args)
        {           
            var weatherForecast = new WeatherForecast()
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            // This code uses asynchronous code to create Json file
            var filename = "WeatherForecast.json";
            using FileStream createStream = File.Create(filename);
            await JsonSerializer.SerializeAsync(createStream, weatherForecast);
            await createStream.DisposeAsync();
            
            Console.WriteLine(File.ReadAllText(filename));
        }
    }
}
