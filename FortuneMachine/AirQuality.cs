using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

namespace FortuneMachine
{
    static class AirQuality
    {
        private static string APIKey = "5869606d5c52d5704667c63ee29dd8fbd1469a2a";
        private static string templateQuery = "https://api.waqi.info/feed/geo:@LAT@;@LON@/?token=";

        private static void LoadAPIKey()
        {
            if (ConfigurationManager.AppSettings.Get("AirQualityAPIKey") != null)
                APIKey = ConfigurationManager.AppSettings.Get("AirQualityAPIKey");
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
                    result = (client.DownloadString(url));
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

        private static string GetQualityByIndex(Single qualityIndex)
        {
            if (qualityIndex < 50)
                return "Bon";
            else if (qualityIndex < 100)
                return "Modéré";
            else if (qualityIndex < 150)
                return "Mauvais pour les groupes sensibles";
            else if (qualityIndex < 200)
                return "Mauvais";
            else if (qualityIndex < 300)
                return "Très mauvais";
            else
                return "Dangereux";
        }

        public static string GetCurrentAirQuality(double latitude, double longitude)
        {
            LoadAPIKey();
            string airQualityReport = "";

            string dataReceived = GetRawData(latitude, longitude);
            if (dataReceived.ToLower().Contains("error"))
            {
                return dataReceived;
            }

            try
            {
                dynamic json = JsonConvert.DeserializeObject(dataReceived);
                Single qualityIndex = Convert.ToSingle(json.data.aqi);
                string quality = GetQualityByIndex(qualityIndex);
                airQualityReport = "Indice de qualité : " + qualityIndex.ToString() + "\n";
                airQualityReport += quality;
                return "ok_" + airQualityReport;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }

        }
    }
}
