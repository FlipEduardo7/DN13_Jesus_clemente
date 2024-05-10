using Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.WindowsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetIp();
            var forecast = GetWeatherForecastAsync(new Zone
            {
                City = "Mexico",
                Date = new DateTime(2024, 05, 10)
            }).Result;

            Console.WriteLine("Ciudad: " + forecast.Zone.City);
            Console.WriteLine("Fecha: " + forecast.Zone.Date);

            Console.ReadKey();
        }

        private static async Task<ZoneWeatherForecast> GetWeatherForecastAsync(Zone zone)
        {
            string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(zone);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:7177/weatherforecast/byzone", new StringContent(jsonContent, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            ZoneWeatherForecast forecast = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeatherForecast>(responseBody);

            //Console.WriteLine("My current Ip Address is: " + ip.Ip);
            //;
            //var info = await GetIpInfo(ip.Ip);

            return forecast;
        }

        private static async Task<IpAddress> GetIp()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);

            Console.WriteLine("My current Ip Address is: " + ip.Ip);
;
            var info = await GetIpInfo(ip.Ip);

            return ip;
        }

        private static async Task<IpInfo> GetIpInfo(string ipAddress)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{ipAddress}/geo");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);

            return info;
        }
    }
}