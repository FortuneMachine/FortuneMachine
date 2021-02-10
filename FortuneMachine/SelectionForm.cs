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
    public partial class SelectionForm : Form
    {

        public string Symbol { get; set; }

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void buttonBelier_Click(object sender, EventArgs e)
        {
            this.Symbol = "belier";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonTaureau_Click(object sender, EventArgs e)
        {
            this.Symbol = "taureau";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonGemeaux_Click(object sender, EventArgs e)
        {
            this.Symbol = "gemeaux";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancer_Click(object sender, EventArgs e)
        {
            this.Symbol = "cancer";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonLion_Click(object sender, EventArgs e)
        {
            this.Symbol = "lion";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonVierge_Click(object sender, EventArgs e)
        {
            this.Symbol = "vierge";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            this.Symbol = "balance";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonScorpion_Click(object sender, EventArgs e)
        {
            this.Symbol = "scorpion";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonSagittaire_Click(object sender, EventArgs e)
        {
            this.Symbol = "sagittaire";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCapricorne_Click(object sender, EventArgs e)
        {
            this.Symbol = "capricorne";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonVerseau_Click(object sender, EventArgs e)
        {
            this.Symbol = "verseau";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonPoisson_Click(object sender, EventArgs e)
        {
            this.Symbol = "poissons";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

