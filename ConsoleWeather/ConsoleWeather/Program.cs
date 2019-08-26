using System;
using Newtonsoft.Json;
using System.Net;

namespace ConsoleWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();

            string key = "YOURKEYHERE";

            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=" + key);

            WebClient web = new WebClient();

            var json = web.DownloadString(url);

            WeatherInfo.RootObject result = JsonConvert.DeserializeObject<WeatherInfo.RootObject>(json);

            WeatherInfo.RootObject outPut = result;

            string.Format("{0}", result.weather[0].main);

            Console.WriteLine("WEATHER BELOW");
            Console.WriteLine(result.weather[0].main);
        }
    }
}
