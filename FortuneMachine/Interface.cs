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

        public void HideTabControlHeaders()
        {
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new Size(0, 1);
            this.tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(weatherForecastPrice) == true)
            {
                if (TryPrintAnswer(Weather.GetWeatherForecast(this.Latitude, this.Longitude)) == true)
                    RemoveCredits(weatherForecastPrice);
            }
        }

        private void buttonChucNorrisFact_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(chuckNorrisFactPrice) == true)
            {
                if (TryPrintAnswer(ChuckNorrisFact.GetJoke()) == true)
                    RemoveCredits(chuckNorrisFactPrice);
            }
        }

        private void buttonAirQuality_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(airQualityPrice) == true)
            {
                if (TryPrintAnswer(AirQuality.GetCurrentAirQuality(this.Latitude, this.Longitude)) == true)
                    RemoveCredits(airQualityPrice);
            }
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(randomMoviePrice) == true)
            {
                if (TryPrintAnswer(Movie.GetRandomMovie()) == true)
                    RemoveCredits(randomMoviePrice);
            }
        }

        private void buttonReceipe_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(randomReceipePrice) == true)
            {
                if (TryPrintAnswer(Receipe.GetRandomReceipe()) == true)
                    RemoveCredits(randomReceipePrice);
            }
        }

        private void buttonAstroWink_Click(object sender, EventArgs e)
        {
            if (CheckSufficientCredits(astroPredictionPrice) == true)
            {
                if (TryPrintAnswer(Horoscope.GetWinkPrediction()) == true)
                    RemoveCredits(astroPredictionPrice);
            }
        }

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
                    //serial.Print(messageToPrint);
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

            if (ConfigurationManager.AppSettings.Get("RandomMoviePrice") != null)
                this.randomMoviePrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("RandomMoviePrice"));

            if (ConfigurationManager.AppSettings.Get("RandomReceipePrice") != null)
                this.randomReceipePrice = Convert.ToInt32(ConfigurationManager.AppSettings.Get("RandomReceipePrice"));

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

        private void labelWelcome_Click(object sender, EventArgs e)
        {
            ShowChoicesPage();
        }

        private void pictureBoxSeeMore_Click(object sender, EventArgs e)
        {
            ShowSeeMorePage();
        }

        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if (this.credits > 0)
                ShowChoicesPage();
            else
                ShowWelcomePage();
        }
    }
}
