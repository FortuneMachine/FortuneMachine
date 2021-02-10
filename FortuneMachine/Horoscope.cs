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

        private static string url = "https://www.asiaflash.com/horoscope/rss_horojour_@SYMBOL@.xml";

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
            string realURL = url.Replace("@SYMBOL@", SelectSymbol());
            Console.WriteLine(realURL);
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(realURL);
            XmlNode rssNode = rssXmlDoc.SelectSingleNode("rss/channel/item/description");
            return rssNode.InnerText;
        }

        
        public static string GetLovePrediction()
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
            return lovePrediction;
        }

        public static string GetMoneyPrediction()
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
            return moneyPrediction;
        }

        public static string GetWorkPrediction()
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
            return workPrediction;
        }

        public static string GetWinkPrediction()
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
            return winkPrediction;
        }
    }
}
