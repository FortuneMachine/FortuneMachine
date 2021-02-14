using System;
using System.Configuration;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FortuneMachine
{
    static class Weather
    {
        private static string APIKey = "48b4c911b4eb888cc5f3b6c7f4484777";
        private static string templateQuery = "https://api.openweathermap.org/data/2.5/onecall?lat=@LAT@&lon=@LON@&exclude=current,minutely,hourly,alerts&units=metric&lang=fr&appid=";

        private static void LoadAPIKey()
        {
            if (ConfigurationManager.AppSettings.Get("WeatherAPIKey") != null)
                APIKey = ConfigurationManager.AppSettings.Get("WeatherAPIKey");
            else
                MessageBox.Show("Erreur lors de la récupération de la clé API, celle par défaut sera utilisée (Vérifier le fichier de configuration)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static string GetRawData(double latitude, double longitude)
        {
            string url = templateQuery + APIKey;
            url = url.Replace("@LAT@", latitude.ToString());
            url = url.Replace("@LON@", longitude.ToString());
            string result;
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                try
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Requête : " + url);
                    result = client.DownloadString(url);
                }
                catch (WebException ex)
                {
                    result = "Error_" + ex.Message;
                }
                catch (Exception ex)
                {
                    result = "Unknown error_" + ex.Message;
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

        public static string GetWeatherForecast(double latitude, double longitude)
        {
            LoadAPIKey();
            string meteoForecast = "";

            string dataReceived = GetRawData(latitude, longitude);
            if (dataReceived.ToLower().Contains("error"))
            {
                return dataReceived;
            }

            try
            {
                dynamic json = JsonConvert.DeserializeObject(dataReceived);
                dynamic dailyNode = json.daily;
                string averageTemp = "";
                string weather = "";

                foreach (var day in dailyNode)
                {
                    double dt = Convert.ToDouble(day.dt);
                    DateTime currDate = UnixTimeStampToDateTime(dt);
                    averageTemp = day.temp.day;
                    //minTemp = day.temp.min;
                    //maxTemp = day.temp.max;
                    weather = day.weather[0].description;

                    meteoForecast += currDate.ToShortDateString() + "\n";
                    meteoForecast += "Température moyenne : " + averageTemp + "°C\n";
                    // Put the first character in uppercase
                    meteoForecast += char.ToUpper(weather[0]) + weather.Substring(1) + "\n\n";
                }
                return "ok_" + meteoForecast;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }

        }
    }
}
