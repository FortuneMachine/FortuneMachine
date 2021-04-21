using System;
using System.Windows.Forms;
using System.Xml;

namespace FortuneMachine
{
    public static class Horoscope
    {

        private static string templateQuery = "https://www.asiaflash.com/horoscope/rss_horojour_@SYMBOL@.xml";

        /// <summary>
        /// Fonction qui permet d'afficher la fenêtre de choix du signe astrologique et de retourner celui sélectionné
        /// </summary>
        /// <returns>Signe astrologique sélectionné</returns>
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

        /// <summary>
        /// Fonction qui permet de récupérer le noeud Description du flux RSS utilisé pour l'Horoscope, celui-ci comprenenant toutes les informations utiles pour le traitement de la demande
        /// </summary>
        /// <returns>Tout ce qui est dans le noeud Description du fichier XML retourné</returns>
        private static string GetRSSNodeDescription()
        {
            string url = templateQuery.Replace("@SYMBOL@", SelectSymbol());
            Console.WriteLine("Requête : " + url);
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(url);
            XmlNode rssNode = rssXmlDoc.SelectSingleNode("rss/channel/item/description");
            return rssNode.InnerText;
        }

        /// <summary>
        /// Fonction qui permet de récupérer la partie Amour de l'horoscope formatée de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
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

        /// <summary>
        /// Fonction qui permet de récupérer la partie Argent de l'horoscope formatée de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
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

        /// <summary>
        /// Fonction qui permet de récupérer la partie Travail de l'horoscope formatée de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
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

        /// <summary>
        /// Fonction qui permet de récupérer la partie Clin d'oeil de l'horoscope formatée de la sorte : {statut de retour}_{message a afficher}_{message a imprimer}
        /// </summary>
        /// <returns>String {statut de retour}_{message a afficher}_{message a imprimer}</returns>
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
