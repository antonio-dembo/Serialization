using System;
using System.Text.Json;               // contains all entry points and main types
using System.Text.Json.Serialization; //contains attributes and APIs for advanced scenarios and customization specific to serialization and deserialization. 

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

            // Write .NET objects as Json (Serialize)
            var jsonString = JsonSerializer.Serialize(weatherForecast);

            //The json output is minified (Whitespace, indentation and new-line caracters are removed) by default
            Console.WriteLine(jsonString);
        }
    }
}
