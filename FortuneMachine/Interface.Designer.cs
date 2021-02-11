
namespace FortuneMachine
{
    partial class Interface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.tabPageChoices = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelChoices = new System.Windows.Forms.TableLayoutPanel();
            this.labelChoicesMessage = new System.Windows.Forms.Label();
            this.ChoicesSpacer = new System.Windows.Forms.Panel();
            this.labelCredits = new System.Windows.Forms.Label();
            this.tabPageSeeMore = new System.Windows.Forms.TabPage();
            this.buttonWeather = new System.Windows.Forms.Button();
            this.buttonChuckNorris = new System.Windows.Forms.Button();
            this.buttonAirQuality = new System.Windows.Forms.Button();
            this.buttonLove = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFortuneTeller = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageChoices.SuspendLayout();
            this.tableLayoutPanelChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFortuneTeller)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWelcome);
            this.tabControlMain.Controls.Add(this.tabPageChoices);
            this.tabControlMain.Controls.Add(this.tabPageSeeMore);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(933, 519);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 24);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWelcome.Size = new System.Drawing.Size(925, 491);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.UseVisualStyleBackColor = true;
            // 
            // tabPageChoices
            // 
            this.tabPageChoices.Controls.Add(this.tableLayoutPanelChoices);
            this.tabPageChoices.Location = new System.Drawing.Point(4, 24);
            this.tabPageChoices.Name = "tabPageChoices";
            this.tabPageChoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChoices.Size = new System.Drawing.Size(925, 491);
            this.tabPageChoices.TabIndex = 1;
            this.tabPageChoices.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelChoices
            // 
            this.tableLayoutPanelChoices.ColumnCount = 10;
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.Controls.Add(this.ChoicesSpacer, 0, 4);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWeather, 1, 6);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonChuckNorris, 4, 6);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonAirQuality, 7, 6);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonLove, 1, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonMoney, 4, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWork, 7, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBox2, 8, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.labelCredits, 9, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.labelChoicesMessage, 2, 2);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBoxFortuneTeller, 3, 0);
            this.tableLayoutPanelChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelChoices.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelChoices.Name = "tableLayoutPanelChoices";
            this.tableLayoutPanelChoices.RowCount = 12;
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.Size = new System.Drawing.Size(919, 485);
            this.tableLayoutPanelChoices.TabIndex = 0;
            // 
            // labelChoicesMessage
            // 
            this.labelChoicesMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChoicesMessage.AutoSize = true;
            this.tableLayoutPanelChoices.SetColumnSpan(this.labelChoicesMessage, 6);
            this.labelChoicesMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelChoicesMessage.Location = new System.Drawing.Point(185, 214);
            this.labelChoicesMessage.Name = "labelChoicesMessage";
            this.labelChoicesMessage.Size = new System.Drawing.Size(540, 24);
            this.labelChoicesMessage.TabIndex = 0;
            this.labelChoicesMessage.Text = "Qu\'est-ce qui t\'amènes aventurier ?";
            this.labelChoicesMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoicesSpacer
            // 
            this.ChoicesSpacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoicesSpacer.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanelChoices.SetColumnSpan(this.ChoicesSpacer, 10);
            this.ChoicesSpacer.Location = new System.Drawing.Point(3, 262);
            this.ChoicesSpacer.Name = "ChoicesSpacer";
            this.ChoicesSpacer.Size = new System.Drawing.Size(913, 1);
            this.ChoicesSpacer.TabIndex = 1;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(822, 0);
            this.labelCredits.Name = "labelCredits";
            this.tableLayoutPanelChoices.SetRowSpan(this.labelCredits, 2);
            this.labelCredits.Size = new System.Drawing.Size(94, 202);
            this.labelCredits.TabIndex = 10;
            this.labelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCredits.Click += new System.EventHandler(this.labelCredits_Click);
            // 
            // tabPageSeeMore
            // 
            this.tabPageSeeMore.Location = new System.Drawing.Point(4, 24);
            this.tabPageSeeMore.Name = "tabPageSeeMore";
            this.tabPageSeeMore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeeMore.Size = new System.Drawing.Size(925, 491);
            this.tabPageSeeMore.TabIndex = 2;
            this.tabPageSeeMore.UseVisualStyleBackColor = true;
            // 
            // buttonWeather
            // 
            this.buttonWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeather.BackgroundImage = global::FortuneMachine.Properties.Resources.weather;
            this.buttonWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWeather, 2);
            this.buttonWeather.Location = new System.Drawing.Point(94, 274);
            this.buttonWeather.Name = "buttonWeather";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWeather, 2);
            this.buttonWeather.Size = new System.Drawing.Size(176, 90);
            this.buttonWeather.TabIndex = 3;
            this.buttonWeather.UseVisualStyleBackColor = true;
            this.buttonWeather.Click += new System.EventHandler(this.buttonWeather_Click);
            // 
            // buttonChuckNorris
            // 
            this.buttonChuckNorris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChuckNorris.BackgroundImage = global::FortuneMachine.Properties.Resources.chuck_norris;
            this.buttonChuckNorris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonChuckNorris, 2);
            this.buttonChuckNorris.Location = new System.Drawing.Point(367, 274);
            this.buttonChuckNorris.Name = "buttonChuckNorris";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonChuckNorris, 2);
            this.buttonChuckNorris.Size = new System.Drawing.Size(176, 90);
            this.buttonChuckNorris.TabIndex = 5;
            this.buttonChuckNorris.UseVisualStyleBackColor = true;
            this.buttonChuckNorris.Click += new System.EventHandler(this.buttonChuckNorris_Click);
            // 
            // buttonAirQuality
            // 
            this.buttonAirQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirQuality.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAirQuality.BackgroundImage")));
            this.buttonAirQuality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonAirQuality, 2);
            this.buttonAirQuality.Location = new System.Drawing.Point(640, 274);
            this.buttonAirQuality.Name = "buttonAirQuality";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonAirQuality, 2);
            this.buttonAirQuality.Size = new System.Drawing.Size(176, 90);
            this.buttonAirQuality.TabIndex = 6;
            this.buttonAirQuality.UseVisualStyleBackColor = true;
            this.buttonAirQuality.Click += new System.EventHandler(this.buttonAirQuality_Click);
            // 
            // buttonLove
            // 
            this.buttonLove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLove.BackgroundImage")));
            this.buttonLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonLove, 2);
            this.buttonLove.Location = new System.Drawing.Point(94, 379);
            this.buttonLove.Name = "buttonLove";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonLove, 2);
            this.buttonLove.Size = new System.Drawing.Size(176, 90);
            this.buttonLove.TabIndex = 4;
            this.buttonLove.UseVisualStyleBackColor = true;
            this.buttonLove.Click += new System.EventHandler(this.buttonAstroLove_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoney.BackgroundImage")));
            this.buttonMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonMoney, 2);
            this.buttonMoney.Location = new System.Drawing.Point(367, 379);
            this.buttonMoney.Name = "buttonMoney";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonMoney, 2);
            this.buttonMoney.Size = new System.Drawing.Size(176, 90);
            this.buttonMoney.TabIndex = 7;
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonAstroMoney_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWork.BackgroundImage")));
            this.buttonWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWork, 2);
            this.buttonWork.Location = new System.Drawing.Point(640, 379);
            this.buttonWork.Name = "buttonWork";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWork, 2);
            this.buttonWork.Size = new System.Drawing.Size(176, 90);
            this.buttonWork.TabIndex = 8;
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonAstroWork_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackgroundImage = global::FortuneMachine.Properties.Resources.coins;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(756, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBox2, 2);
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxFortuneTeller
            // 
            this.pictureBoxFortuneTeller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFortuneTeller.BackgroundImage = global::FortuneMachine.Properties.Resources.fortuner_teller;
            this.pictureBoxFortuneTeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.pictureBoxFortuneTeller, 4);
            this.pictureBoxFortuneTeller.Location = new System.Drawing.Point(276, 3);
            this.pictureBoxFortuneTeller.Name = "pictureBoxFortuneTeller";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBoxFortuneTeller, 2);
            this.pictureBoxFortuneTeller.Size = new System.Drawing.Size(358, 196);
            this.pictureBoxFortuneTeller.TabIndex = 2;
            this.pictureBoxFortuneTeller.TabStop = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface";
            this.Text = "Fortune Machine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interface_FormClosing);
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageChoices.ResumeLayout(false);
            this.tableLayoutPanelChoices.ResumeLayout(false);
            this.tableLayoutPanelChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFortuneTeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPageChoices;
        private System.Windows.Forms.TabPage tabPageSeeMore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChoices;
        private System.Windows.Forms.Label labelChoicesMessage;
        private System.Windows.Forms.Panel ChoicesSpacer;
        private System.Windows.Forms.Button buttonWeather;
        private System.Windows.Forms.Button buttonLove;
        private System.Windows.Forms.Button buttonChuckNorris;
        private System.Windows.Forms.Button buttonAirQuality;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.PictureBox pictureBoxFortuneTeller;
    }
}

