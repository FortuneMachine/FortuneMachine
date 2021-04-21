using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FortuneMachine
{
    static class ChuckNorrisFact
    {
        private static string templateQuery = "http://api.icndb.com/jokes/random";
        private static Boolean explicitContent = true;

        /// <summary>
        /// Fonction qui permet de récupérer les datas telles qu'elles sont retournées par le Client Web
        /// </summary>
        /// <returns>Datas reçues / Error_ + Error Message / Unknown error_ + Error Message</returns>
        private static string GetRawData()
        {
            string result = "";
            string url = "";
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                try
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    if (explicitContent == true)
                        url = templateQuery;
                    else
                        url = templateQuery + "?exclude=[explicit]";
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

        /// <summary>
        /// Fonction qui permet de récupérer une blague sur Chuck Norris formatée de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
        public static string GetJoke()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            string dataReceived = GetRawData();
            if (dataReceived.ToLower().Contains("error_"))
            {
                return dataReceived;
            }

            try
            {
                dynamic json = JsonConvert.DeserializeObject(dataReceived);
                string joke = json.value.joke;
                joke = joke.Replace("&quot;", @"""");

                returnStatus = "ok";

                messageToShow = joke;

                messageToPrint = joke;
            }
            catch (Exception ex)
            {
                returnStatus = "error";
                messageToShow = ex.Message;
                messageToPrint = "error";
            }
            return String.Format("{0}_{1}_{2}", returnStatus, messageToShow, messageToPrint);
        }

        /// <summary>
        /// Fonction qui permet de définir si oui ou non on veut des blagues dites 'explicit' ou non
        /// </summary>
        /// <param name="enable">True : explicit / False : non explicit</param>
        public static void EnableExplicit(bool enable)
        {
            explicitContent = enable;
        }
    }
}
