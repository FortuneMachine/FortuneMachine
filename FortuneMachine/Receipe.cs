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
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(url);
            XmlNodeList receipes = rssXmlDoc.GetElementsByTagName("item");
            Random rnd = new Random();
            XmlNode node = receipes[rnd.Next(0, receipes.Count)].SelectSingleNode("title");
            return node.InnerText;
        }


        public static string GetRandomReceipe()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            try
            {
                string receipeTitle = GetOneReceipe();

                returnStatus = "ok";
                messageToShow = "Recette tirée : " + receipeTitle;
                messageToPrint = receipeTitle;
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
