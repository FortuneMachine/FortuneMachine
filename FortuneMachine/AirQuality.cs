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
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            string dataReceived = GetRawData(latitude, longitude);
            if (dataReceived.ToLower().Contains("error_"))
            {
                return dataReceived;
            }

            try
            {
                dynamic json = JsonConvert.DeserializeObject(dataReceived);
                Single qualityIndex = Convert.ToSingle(json.data.aqi);
                string quality = GetQualityByIndex(qualityIndex);
                string carbon = Convert.ToString(json.data.iaqi.co.v); // monoxyde de carbone
                string azote = Convert.ToString(json.data.iaqi.no2.v); // dioxyde d'azote
                string ozone = Convert.ToString(json.data.iaqi.o3.v);
                string PM25 = Convert.ToString(json.data.iaqi.pm25.v);
                string PM10 = Convert.ToString(json.data.iaqi.pm10.v);

                returnStatus = "ok";

                messageToShow = String.Format("Indice de qualité de l'air : {0} ({1}) \n", qualityIndex, quality);
                messageToShow += String.Format(" - Monoxyde de carbone : {0} \n", carbon);
                messageToShow += String.Format(" - Dioxyde d'azote : {0} \n", azote);
                messageToShow += String.Format(" - Ozone : {0} \n", ozone);
                messageToShow += String.Format(" - PM 2.5 : {0} \n", PM25);
                messageToShow += String.Format(" - PM 10 : {0} \n", PM10);
                
                messageToPrint = String.Format("Qualité de l'air : {0} ({1}) \n", qualityIndex, quality);              
            }
            catch (Exception ex)
            {
                returnStatus = "error";
                messageToShow = ex.Message;
                messageToPrint = "error";
            }
            return String.Format("{0}_{1}_{2}", returnStatus, messageToShow, messageToPrint);
        }
    }
}
