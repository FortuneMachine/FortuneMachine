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
        private static string _basicURL = "http://api.icndb.com/jokes/random";
        private static Boolean _explicit = true;

        public static string GetOneJoke()
        {
            string joke = "";
            string url = "";
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                try
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    if (_explicit == true)
                        url = _basicURL;
                    else
                        url = _basicURL + "?exclude=[explicit]";
                    joke = ParseAnswer(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(joke);
            return joke;
        }

        private static string ParseAnswer(string json)
        {
            dynamic stuff = JsonConvert.DeserializeObject(json);
            dynamic joke = stuff.value.joke;
            return joke;
        }

        public static void EnableExplicit(bool enable)
        {
            _explicit = enable;
        }
    }
}
