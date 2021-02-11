﻿using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace FortuneMachine
{
    public partial class Interface : Form
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        private int credits = 0;
        private int weatherForecastPrice = 1;
        private int chuckNorrisFactPrice = 1;
        private int airQualityPrice = 1;
        private int astroPredictionPrice = 1;

        public Interface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode executée au lors du chargement de la fenêtre principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Load(object sender, EventArgs e)
        {
            LoadConfig();
            HideTabControlHeaders();
            // TODO : Default apge = WelcomePage
            ShowChoicesPage();
            UpdateCreditsDisplay();
            this.Latitude = 0;
            this.Longitude = 0;
            GPS tempGPS = new GPS(this);
            tempGPS.UpdateLocation();
        }


        /// <summary>
        /// Méthode pour cacher les onglets pour les différentes pages (Bienvenue, choix, à propos)
        /// </summary>
        public void HideTabControlHeaders()
        {
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new Size(0, 1);
            this.tabControlMain.SizeMode = TabSizeMode.Fixed;
        }


        /// <summary>
        /// Méthode qui gère l'appui sur le bouton Météo
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
        /// Méthode qui gère l'appui sur le bouton Chuck Norris Fact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChuckNorris_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(chuckNorrisFactPrice) == true)
            {
                if (TryPrintAnswer(ChuckNorrisFact.GetJoke()) == true)
                    RemoveCredits(chuckNorrisFactPrice);
            }
        }


        /// <summary>
        /// Méthode qui gère l'appui sur le bouton Qualité de l'air
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
        /// Méthode qui gère l'appui sur le bouton Horoscope Amour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAstroLove_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(astroPredictionPrice) == true)
            {
                if (TryPrintAnswer(Horoscope.GetLovePrediction()) == true)
                    RemoveCredits(astroPredictionPrice);
            }
        }


        /// <summary>
        /// Méthode qui gère l'appui sur le bouton Horoscope Argent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAstroMoney_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(astroPredictionPrice) == true)
            {
                if (TryPrintAnswer(Horoscope.GetMoneyPrediction()) == true)
                    RemoveCredits(astroPredictionPrice);
            }
        }


        /// <summary>
        /// Méthode qui gère l'appui sur le bouton Horoscope Travail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAstroWork_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(astroPredictionPrice) == true)
            {
                if (TryPrintAnswer(Horoscope.GetWorkPrediction()) == true)
                    RemoveCredits(astroPredictionPrice);
            }
        }

        private bool TryPrintAnswer(string answer)
        {
            string[] temp = answer.Split('_');
            if (temp.Length < 2)
            {
                MessageBox.Show("Erreur avec le message de retour : " + answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string status = temp[0];
            string message = temp[1];
            if (status.ToLower().Contains("ok"))
            {
                MessageBox.Show(message, "Succes", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show(message, status, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

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

        private void AddCredits(int creditsToAdd)
        {
            this.credits += creditsToAdd;
            UpdateCreditsDisplay();
        }

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

        private void UpdateCreditsDisplay()
        {
            this.labelCredits.Text = this.credits.ToString();
        }

        private void ShowWelcomePage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageWelcome)
                this.tabControlMain.SelectedTab = this.tabPageWelcome;
        }

        private void ShowChoicesPage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageChoices)
                this.tabControlMain.SelectedTab = this.tabPageChoices;
        }

        private void ShowSeeMorePage()
        {
            if (this.tabControlMain.SelectedTab != this.tabPageSeeMore)
                this.tabControlMain.SelectedTab = this.tabPageSeeMore;
        }

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
        }

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

        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCredits();
        }

        private void labelCredits_Click(object sender, EventArgs e)
        {
            AddCredits(1);
        }
    }
}
