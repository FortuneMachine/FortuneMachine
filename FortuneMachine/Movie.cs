using System;
using System.Configuration;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FortuneMachine
{
    public static class Movie
    {
        private static string APIKey = "d092d7787fe120f6afb97ee96c9481d5";
        private static string templateQuery = "https://api.themoviedb.org/3/trending/movie/day?api_key=@API_KEY@&language=fr-FR";

        /// <summary>
        /// Fonction qui permet de récupérer la clé API en paramètre dans le fichier de config sous le nom MovieAPIKey
        /// </summary>
        private static void LoadAPIKey()
        {
            if (ConfigurationManager.AppSettings.Get("MovieAPIKey") != null)
                APIKey = ConfigurationManager.AppSettings.Get("MovieAPIKey");
            else
                MessageBox.Show("Erreur lors de la récupération de la clé API, celle par défaut sera utilisée (Vérifier le fichier de configuration)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Fonction qui permet de récupérer les datas telles qu'elles sont retournées par le Client Web
        /// </summary>
        /// <returns>Datas reçues / Error_ + Error Message / Unknown error_ + Error Message</returns>
        private static string GetRawData()
        {
            string url = templateQuery.Replace("@API_KEY@",APIKey);
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

        /// <summary>
        /// Fonction qui permet de récupérer un titre de film aléatoire formaté de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
        public static string GetRandomMovie()
        {
            LoadAPIKey();
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
                Random rnd = new Random();
                string randomMovieTitle = json.results[rnd.Next(0, 20)].title;

                returnStatus = "ok";
                messageToShow = "Film : " + randomMovieTitle;
                messageToPrint = randomMovieTitle;
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
