using System;
using System.Windows.Forms;
using System.Xml;

namespace FortuneMachine
{
    class Receipe
    {

        private static string url = "https://cuisine-facile.com/rss-news.xml";

        private static string GetOneReceipe()
        {
            string url = "https://cuisine-facile.com/rss-news.xml";
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(url);
            XmlNodeList receipes = rssXmlDoc.GetElementsByTagName("item");
            Random rnd = new Random();
            XmlNode node = receipes[rnd.Next(0, receipes.Count)].SelectSingleNode("title");
            return node.InnerText;
        }


        public static string GetRandomReceipe()
        {
            try
            {
                string receipe = "";
                receipe = GetOneReceipe();
                return "ok_" + receipe;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }
        }
    }
}
