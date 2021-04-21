using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace FortuneMachine
{
    public partial class Interface : Form
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        private SerialCommunication serial;

        private int credits = 0;
        private int weatherForecastPrice = 1;
        private int chuckNorrisFactPrice = 1;
        private int airQualityPrice = 1;
        private int astroPredictionPrice = 1;
        private int randomMoviePrice = 1;
        private int randomReceipePrice = 1;

        public Interface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelée au chargement de l'interface graphique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Load(object sender, EventArgs e)
        {
            LoadConfig();
            HideTabControlHeaders();
            if (this.credits > 0)
                ShowChoicesPage();
            else
                ShowWelcomePage();
            UpdateCreditsDisplay();
            this.Latitude = 0;
            this.Longitude = 0;
            GPS tempGPS = new GPS(this);
            tempGPS.UpdateLocation();
            serial = new SerialCommunication();
        }

        /// <summary>
        /// Fonction permettant de cacher les onglets du TabControl utilisé pour naviguer entre les différentes pages
        /// </summary>
        public void HideTabControlHeaders()
        {
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new Size(0, 1);
            this.tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton Météo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeather_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(weatherForecastPrice) == true)
            {
                if (TryPrintAnswer(Weather.GetWeatherForecast(this.Latitude, this.Longitude)) == true)
                    RemoveCredits(weatherForecastPrice);
            }
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton Chuck Norris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChucNorrisFact_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(chuckNorrisFactPrice) == true)
            {
                if (TryPrintAnswer(ChuckNorrisFact.GetJoke()) == true)
                    RemoveCredits(chuckNorrisFactPrice);
            }
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton qualité de l'air
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAirQuality_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(airQualityPrice) == true)
            {
                if (TryPrintAnswer(AirQuality.GetCurrentAirQuality(this.Latitude, this.Longitude)) == true)
                    RemoveCredits(airQualityPrice);
            }
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton Film aléatoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMovie_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(randomMoviePrice) == true)
            {
                if (TryPrintAnswer(Movie.GetRandomMovie()) == true)
                    RemoveCredits(randomMoviePrice);
            }
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton Recette aléatoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReceipe_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(randomReceipePrice) == true)
            {
                if (TryPrintAnswer(Receipe.GetRandomReceipe()) == true)
                    RemoveCredits(randomReceipePrice);
            }
        }

        /// <summary>
        /// Fonction appelée lors du clic sur le bouton Horoscope
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAstroWink_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(astroPredictionPrice) == true)
            {
                if (TryPrintAnswer(Horoscope.GetWinkPrediction()) == true)
                    RemoveCredits(astroPredictionPrice);
            }
        }

        /// <summary>
        /// Fonction qui permet de formater le message de retour lors de la recherche d'information. Permet d'afficher les informations si elles ont bien été obtenues ou le message d'erreur adapté sinon.
        /// </summary>
        /// <param name="answer"></param>
        /// <returns>True : Informations correctement récupérées / False : Message d'erreur récupéré</returns>
        private bool TryPrintAnswer(string answer)
        {
            string[] temp = answer.Split('_');
            if (temp.Length < 3)
            {
                MessageBox.Show("Erreur avec le message de retour : " + answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                string status = temp[0];
                string messageToShow = temp[1];
                string messageToPrint = temp[2];

                if (status.ToLower().Contains("ok"))
                {
                    MessageBox.Show(messageToShow, "Succes", MessageBoxButtons.OK);
                    serial.Print(messageToPrint);
                    return true;
                }
                else
                {
                    MessageBox.Show(messageToShow, status, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Fonction qui permet de vérifier que l'utilisateur dispose de suffisamment de crédits pour obtenir l'information qu'il cherche à acquérir
        /// </summary>
        /// <param name="price">Prix de l'information que l'utilisateur cherche à acquérir (en crédits)</param>
        /// <returns>True : Crédits suffisants / False : Crédits insuffisants</returns>
        private bool CheckSufficientCredits(int price)
        {
            if (this.credits <= 0)
            {
                MessageBox.Show("Vous n'avez plus de crédits", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowWelcomePage();
                return false;
            }
            else if (this.credits < price)
            {
                MessageBox.Show("Crédits insuffisants", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Fonction qui permet d'ajouter des crédits à la balance
        /// </summary>
        /// <param name="creditsToAdd">Nombre de crédits à ajouter à la balance</param>
        private void AddCredits(int creditsToAdd)
        {
            this.credits += creditsToAdd;
            UpdateCreditsDisplay();
        }

        /// <summary>
        /// Fonction qui permet de retirer des crédits de la balance
        /// </summary>
        /// <param name="price">Nombre de crédits à retirer de la balance</param>
        private void RemoveCredits(int price)
        {
            this.credits -= price;
            UpdateCreditsDisplay();
            if (this.credits <= 0)
            {
                MessageBox.Show("Vous n'avez plus de crédits", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowWelcomePage();
            }
        }

        /// <summary>
        /// Fonction qui permet de mettre à jour les crédits restants sur l'interface graphique
        /// </summary>
        private void UpdateCreditsDisplay()
        {
            this.labelCredits.Text = this.credits.ToString();
        }

        /// <summary>
        /// Fonction qui permet de d'afficher la page d'accueil
        /// </summary>
        private void ShowWelcomePage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageWelcome)
                this.tabControlMain.SelectedTab = this.tabPageWelcome;
        }

        /// <summary>
        /// Fonction qui permet d'afficher la page des choix
        /// </summary>
        private void ShowChoicesPage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageChoices)
                this.tabControlMain.SelectedTab = this.tabPageChoices;
        }

        /// <summary>
        /// Fonction qui permet d'afficher la page a propos
        /// </summary>
        private void ShowSeeMorePage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageSeeMore)
                this.tabControlMain.SelectedTab = this.tabPageSeeMore;
        }

        /// <summary>
        /// Fonction qui permet de charger les paramètres en fonction des valeurs récupérées dans le fichier de configuration
        /// </summary>
        private void LoadConfig()
        {
            if (ConfigurationManager.AppSettings.Get("Credits") != null)
                this.credits = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Credits"));

            if (ConfigurationManager.AppSettings.Get("WeatherForecastPrice") != null)
            this.weatherForecastPrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("WeatherForecastPrice"));

            if (ConfigurationManager.AppSettings.Get("ChuckNorrisFactPrice") != null)
                this.chuckNorrisFactPrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("ChuckNorrisFactPrice"));

            if (ConfigurationManager.AppSettings.Get("AirQualityPrice") != null)
                this.airQualityPrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("AirQualityPrice"));

            if (ConfigurationManager.AppSettings.Get("AstroPredictionPrice") != null)
                this.astroPredictionPrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("AstroPredictionPrice"));

            if (ConfigurationManager.AppSettings.Get("RandomMoviePrice") != null)
                this.randomMoviePrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("RandomMoviePrice"));

            if (ConfigurationManager.AppSettings.Get("RandomReceipePrice") != null)
                this.randomReceipePrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("RandomReceipePrice"));

        }

        /// <summary>
        /// Fonction qui permet de sauvegarder le nombre de crédits restants dans le fichier de configuration pour le prochain lancement éventuellement
        /// </summary>
        private void SaveCredits()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["Credits"] == null)
            {
                settings.Add("Credits", this.credits.ToString());
            }
            else
            {
                settings["Credits"].Value = this.credits.ToString();
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        /// <summary>
        /// Fonction appelée lors de la fermeture de l'interface graphique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCredits();
        }

        /// <summary>
        /// Fonction temporaire qui permet d'ajouter des crédits lors d'un clic sur le nombre de crédits dans la page de choix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCredits_Click(object sender, EventArgs e)
        {
            AddCredits(1);
        }

        /// <summary>
        ///  Fonction temporaire qui permet de passer à la page de choix lors d'un clic sur le message de bienvenue 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWelcome_Click(object sender, EventArgs e)
        {
            ShowChoicesPage();
        }

        /// <summary>
        /// Fonction qui permet d'afficher la page a propos lors d'un clic sur l'icone "?"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSeeMore_Click(object sender, EventArgs e)
        {
            ShowSeeMorePage();
        }

        /// <summary>
        /// Fonction qui permet d'afficher la page attendue lors d'un clic sur le bouton de retour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if (this.credits > 0)
                ShowChoicesPage();
            else
                ShowWelcomePage();
        }
    }
}
