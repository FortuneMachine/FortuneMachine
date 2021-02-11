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

        public static string GetRawData()
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

        public static string GetJoke()
        {
            string joke = "";

            string dataReceived = GetRawData();
            if (dataReceived.ToLower().Contains("error"))
            {
                return dataReceived;
            }

            try
            {
                dynamic json = JsonConvert.DeserializeObject(dataReceived);
                joke = json.value.joke;
                return "ok_" + joke;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }

        }

        // TODO : Mettre en paramètre
        public static void EnableExplicit(bool enable)
        {
            explicitContent = enable;
        }
    }
}
