using System;
using System.Windows.Forms;
using System.Xml;

namespace FortuneMachine
{
    public static class Horoscope
    {

        private static string templateQuery = "https://www.asiaflash.com/horoscope/rss_horojour_@SYMBOL@.xml";

        public static string SelectSymbol()
        {
            using(var form = new SelectionForm())
{
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return form.Symbol;
                }
                else
                {
                    return "";
                }
            }
        }

        private static string GetRSSNodeDescription()
        {
            string url = templateQuery.Replace("@SYMBOL@", SelectSymbol());
            Console.WriteLine("Requête : " + url);
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(url);
            XmlNode rssNode = rssXmlDoc.SelectSingleNode("rss/channel/item/description");
            return rssNode.InnerText;
        }

        
        public static string GetLovePrediction()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            try
            {
                string description = GetRSSNodeDescription();
                string[] sections = description.Split(new String[] { "<br><br>" }, StringSplitOptions.None);
                foreach (string section in sections)
                {
                    string[] parts = section.Split(new String[] { "</b><br>" }, StringSplitOptions.None);
                    if (parts.Length < 2)
                        continue;
                    string partTitle = parts[0];
                    string partText = parts[1];
                    if (partTitle.Contains("Amour"))
                    {
                        returnStatus = "ok";
                        messageToShow = "Amour : " + partText;
                        if (partText.Length > 100)
                            messageToPrint = partText.Substring(0, 100) + "...";
                        else
                            messageToPrint = partText;
                    }
                }
            }
            catch (Exception ex)
            {
                returnStatus = "error";
                messageToShow = ex.Message;
                messageToPrint = "error";
            }
            return String.Format("{0}_{1}_{2}", returnStatus, messageToShow, messageToPrint);
        }

        public static string GetMoneyPrediction()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            try
            {
                string description = GetRSSNodeDescription();
                string[] sections = description.Split(new String[] { "<br><br>" }, StringSplitOptions.None);
                foreach (string section in sections)
                {
                    string[] parts = section.Split(new String[] { "</b><br>" }, StringSplitOptions.None);
                    if (parts.Length < 2)
                        continue;
                    string partTitle = parts[0];
                    string partText = parts[1];
                    if (partTitle.Contains("Argent"))
                    {
                        returnStatus = "ok";
                        messageToShow = "Argent : " + partText;
                        if (partText.Length > 100)
                            messageToPrint = partText.Substring(0, 100) + "...";
                        else
                            messageToPrint = partText;
                    }
                }
            }
            catch (Exception ex)
            {
                returnStatus = "error";
                messageToShow = ex.Message;
                messageToPrint = "error";
            }
            return String.Format("{0}_{1}_{2}", returnStatus, messageToShow, messageToPrint);
        }

        public static string GetWorkPrediction()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            try
            {
                string description = GetRSSNodeDescription();
                string[] sections = description.Split(new String[] { "<br><br>" }, StringSplitOptions.None);
                foreach (string section in sections)
                {
                    string[] parts = section.Split(new String[] { "</b><br>" }, StringSplitOptions.None);
                    if (parts.Length < 2)
                        continue;
                    string partTitle = parts[0];
                    string partText = parts[1];
                    if (partTitle.Contains("Travail"))
                    {
                        returnStatus = "ok";
                        messageToShow = "Travail : " + partText;
                        if (partText.Length > 100)
                            messageToPrint = partText.Substring(0, 100) + "...";
                        else
                            messageToPrint = partText;
                    }
                }
            }
            catch (Exception ex)
            {
                returnStatus = "error";
                messageToShow = ex.Message;
                messageToPrint = "error";
            }
            return String.Format("{0}_{1}_{2}", returnStatus, messageToShow, messageToPrint);
        }

        public static string GetWinkPrediction()
        {
            string returnStatus = "";
            string messageToShow = "";
            string messageToPrint = "";

            try
            { 
                string description = GetRSSNodeDescription();
                string[] sections = description.Split(new String[] { "<br><br>" }, StringSplitOptions.None);
                foreach (string section in sections)
                {
                    string[] parts = section.Split(new String[] { "</b><br>" }, StringSplitOptions.None);
                    if (parts.Length < 2)
                        continue;
                    string partTitle = parts[0];
                    string partText = parts[1];
                    if (partTitle.Contains("Clin d'oeil"))
                    {
                        returnStatus = "ok";
                        messageToShow = "Clin d'oeil : " + partText;
                        if (partText.Length > 100)
                            messageToPrint = partText.Substring(0, 100) + "...";
                        else
                            messageToPrint = partText;
                    }
                }
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
