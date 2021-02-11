using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                string lovePrediction = "_";
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
                        lovePrediction = partText;
                }
                return "ok_" + lovePrediction;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }

        }

        public static string GetMoneyPrediction()
        {
            try
            { 
                string moneyPrediction = "_";
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
                        moneyPrediction = partText;
                }
                return "ok_" + moneyPrediction;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }
        }

        public static string GetWorkPrediction()
        {
            try
            { 
                string workPrediction = "_";
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
                        workPrediction = partText;
                }
                return "ok_" + workPrediction;
                }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }
        }

        public static string GetWinkPrediction()
        {
            try
            { 
                string winkPrediction = "_";
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
                        winkPrediction = partText;
                }
                return "ok_" + winkPrediction;
            }
            catch (Exception ex)
            {
                return "error_" + ex.Message;
            }
        }
    }
}
