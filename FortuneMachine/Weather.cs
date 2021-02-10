using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device;
using System.Device.Location;
using System.Net;
using Newtonsoft.Json;

namespace FortuneMachine
{
    static class Weather
    {

        private static string APIKey = "48b4c911b4eb888cc5f3b6c7f4484777";
        private static string basicQuery = "https://api.openweathermap.org/data/2.5/onecall?lat=@LAT@&lon=@LON@&exclude=current,minutely,hourly,alerts&units=metric&lang=fr&appid=" + APIKey;

        private static string GetData(double latitude, double longitude)
        {
            string url = basicQuery.Replace("@LAT@", latitude.ToString());
            url = url.Replace("@LON@", longitude.ToString());
            string result;
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                try
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Lien : " + url);
                    result = (client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    result = "Error : " + ex.Message;
                }
                catch (Exception ex)
                {
                    result = "Unknown error : " + ex.Message;
                }
                return result;
            }
        }

        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static string GetMeteoPrediction(double latitude, double longitude)
        {
            string dataReceived = GetData(latitude, longitude);
            if (dataReceived.ToLower().Contains("error"))
            {
                return dataReceived;
            }

            dynamic stuff = JsonConvert.DeserializeObject(dataReceived);
            dynamic daily = stuff.daily;
            string averageTemp = "";
            string weather = "";
            string formatedText = "";
            foreach (var day in daily)
            {
                double dt = Convert.ToDouble(day.dt);
                DateTime currDate = UnixTimeStampToDateTime(dt);
                averageTemp = day.temp.day;
                //minTemp = day.temp.min;
                //maxTemp = day.temp.max;
                weather = day.weather[0].description;

                formatedText += currDate.ToShortDateString() + "\n";
                formatedText += "Température moyenne : " + averageTemp + "°C\n";
                // Put the first character in uppercase
                formatedText += char.ToUpper(weather[0]) + weather.Substring(1) + "\n\n";
            }
            return formatedText;
        }
    }
}
