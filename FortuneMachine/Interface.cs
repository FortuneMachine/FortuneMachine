using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneMachine
{
    public partial class Interface : Form
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            HideTabControlHeaders();
            this.tabControlMain.SelectedTab = this.tabPageChoices;
            this.Latitude = 0;
            this.Longitude = 0;
            GPS gps = new GPS(this);
            gps.GetLocationDataEvent();
        }

        public void HideTabControlHeaders()
        {
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new Size(0, 1);
            this.tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ChuckNorrisFact.GetOneJoke());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Horoscope.GetLovePrediction();
        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Weather.GetMeteoPrediction(this.Latitude, this.Longitude));
        }

        private void buttonChuckNorris_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ChuckNorrisFact.GetOneJoke());
        }

        private void buttonWink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Horoscope.GetWinkPrediction());
        }

        private void buttonLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Horoscope.GetLovePrediction());
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Horoscope.GetMoneyPrediction());
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Horoscope.GetWorkPrediction());
        }
    }
}
