
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
            this.ChoicesSpacer = new System.Windows.Forms.Panel();
            this.buttonWeather = new System.Windows.Forms.Button();
            this.buttonAirQuality = new System.Windows.Forms.Button();
            this.buttonMovie = new System.Windows.Forms.Button();
            this.buttonReceipe = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelChoicesMessage = new System.Windows.Forms.Label();
            this.pictureBoxFortuneTeller = new System.Windows.Forms.PictureBox();
            this.pictureBoxSeeMore = new System.Windows.Forms.PictureBox();
            this.buttonChucNorrisFact = new System.Windows.Forms.Button();
            this.tabPageSeeMore = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageChoices.SuspendLayout();
            this.tableLayoutPanelChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFortuneTeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeeMore)).BeginInit();
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
            this.tabControlMain.Size = new System.Drawing.Size(800, 480);
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
            this.tabPageChoices.Size = new System.Drawing.Size(792, 452);
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
            this.tableLayoutPanelChoices.Controls.Add(this.buttonAirQuality, 7, 6);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonMovie, 1, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonReceipe, 4, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWork, 7, 9);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBox2, 8, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.labelCredits, 9, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.labelChoicesMessage, 2, 2);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBoxFortuneTeller, 3, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBoxSeeMore, 1, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonChucNorrisFact, 4, 6);
            this.tableLayoutPanelChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelChoices.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelChoices.Name = "tableLayoutPanelChoices";
            this.tableLayoutPanelChoices.RowCount = 12;
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16598F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.751038F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanelChoices.Size = new System.Drawing.Size(786, 446);
            this.tableLayoutPanelChoices.TabIndex = 0;
            // 
            // ChoicesSpacer
            // 
            this.ChoicesSpacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoicesSpacer.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanelChoices.SetColumnSpan(this.ChoicesSpacer, 10);
            this.ChoicesSpacer.Location = new System.Drawing.Point(3, 241);
            this.ChoicesSpacer.Name = "ChoicesSpacer";
            this.ChoicesSpacer.Size = new System.Drawing.Size(780, 1);
            this.ChoicesSpacer.TabIndex = 1;
            // 
            // buttonWeather
            // 
            this.buttonWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeather.BackgroundImage = global::FortuneMachine.Properties.Resources.weather;
            this.buttonWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWeather, 2);
            this.buttonWeather.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            this.buttonWeather.FlatAppearance.BorderSize = 2;
            this.buttonWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(190)))), ((int)(((byte)(251)))));
            this.buttonWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(190)))), ((int)(((byte)(251)))));
            this.buttonWeather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWeather.Location = new System.Drawing.Point(81, 252);
            this.buttonWeather.Name = "buttonWeather";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWeather, 2);
            this.buttonWeather.Size = new System.Drawing.Size(150, 82);
            this.buttonWeather.TabIndex = 3;
            this.buttonWeather.TabStop = false;
            this.buttonWeather.UseVisualStyleBackColor = true;
            this.buttonWeather.Click += new System.EventHandler(this.buttonWeather_Click);
            // 
            // buttonAirQuality
            // 
            this.buttonAirQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirQuality.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAirQuality.BackgroundImage")));
            this.buttonAirQuality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonAirQuality, 2);
            this.buttonAirQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAirQuality.Location = new System.Drawing.Point(549, 252);
            this.buttonAirQuality.Name = "buttonAirQuality";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonAirQuality, 2);
            this.buttonAirQuality.Size = new System.Drawing.Size(150, 82);
            this.buttonAirQuality.TabIndex = 6;
            this.buttonAirQuality.TabStop = false;
            this.buttonAirQuality.UseVisualStyleBackColor = true;
            this.buttonAirQuality.Click += new System.EventHandler(this.buttonAirQuality_Click);
            // 
            // buttonMovie
            // 
            this.buttonMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMovie.BackgroundImage = global::FortuneMachine.Properties.Resources.multimedia;
            this.buttonMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonMovie, 2);
            this.buttonMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(164)))), ((int)(((byte)(249)))));
            this.buttonMovie.FlatAppearance.BorderSize = 2;
            this.buttonMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(190)))), ((int)(((byte)(251)))));
            this.buttonMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(190)))), ((int)(((byte)(251)))));
            this.buttonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMovie.Location = new System.Drawing.Point(81, 348);
            this.buttonMovie.Name = "buttonMovie";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonMovie, 2);
            this.buttonMovie.Size = new System.Drawing.Size(150, 82);
            this.buttonMovie.TabIndex = 4;
            this.buttonMovie.TabStop = false;
            this.buttonMovie.UseVisualStyleBackColor = true;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // buttonReceipe
            // 
            this.buttonReceipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReceipe.BackgroundImage = global::FortuneMachine.Properties.Resources.cooking;
            this.buttonReceipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonReceipe, 2);
            this.buttonReceipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReceipe.Location = new System.Drawing.Point(315, 348);
            this.buttonReceipe.Name = "buttonReceipe";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonReceipe, 2);
            this.buttonReceipe.Size = new System.Drawing.Size(150, 82);
            this.buttonReceipe.TabIndex = 7;
            this.buttonReceipe.TabStop = false;
            this.buttonReceipe.UseVisualStyleBackColor = true;
            this.buttonReceipe.Click += new System.EventHandler(this.buttonReceipe_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWork.BackgroundImage")));
            this.buttonWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWork, 2);
            this.buttonWork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWork.Location = new System.Drawing.Point(549, 348);
            this.buttonWork.Name = "buttonWork";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWork, 2);
            this.buttonWork.Size = new System.Drawing.Size(150, 82);
            this.buttonWork.TabIndex = 8;
            this.buttonWork.TabStop = false;
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonAstroWink_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackgroundImage = global::FortuneMachine.Properties.Resources.coins;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(627, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBox2, 2);
            this.pictureBox2.Size = new System.Drawing.Size(72, 100);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(705, 0);
            this.labelCredits.Name = "labelCredits";
            this.tableLayoutPanelChoices.SetRowSpan(this.labelCredits, 2);
            this.labelCredits.Size = new System.Drawing.Size(78, 186);
            this.labelCredits.TabIndex = 10;
            this.labelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCredits.Click += new System.EventHandler(this.labelCredits_Click);
            // 
            // labelChoicesMessage
            // 
            this.labelChoicesMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChoicesMessage.AutoSize = true;
            this.tableLayoutPanelChoices.SetColumnSpan(this.labelChoicesMessage, 6);
            this.labelChoicesMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelChoicesMessage.Location = new System.Drawing.Point(159, 196);
            this.labelChoicesMessage.Name = "labelChoicesMessage";
            this.labelChoicesMessage.Size = new System.Drawing.Size(462, 24);
            this.labelChoicesMessage.TabIndex = 0;
            this.labelChoicesMessage.Text = "Qu\'est-ce qui t\'amènes aventurier ?";
            this.labelChoicesMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFortuneTeller
            // 
            this.pictureBoxFortuneTeller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFortuneTeller.BackgroundImage = global::FortuneMachine.Properties.Resources.fortuner_teller;
            this.pictureBoxFortuneTeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.pictureBoxFortuneTeller, 4);
            this.pictureBoxFortuneTeller.Location = new System.Drawing.Point(237, 3);
            this.pictureBoxFortuneTeller.Name = "pictureBoxFortuneTeller";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBoxFortuneTeller, 2);
            this.pictureBoxFortuneTeller.Size = new System.Drawing.Size(306, 180);
            this.pictureBoxFortuneTeller.TabIndex = 2;
            this.pictureBoxFortuneTeller.TabStop = false;
            // 
            // pictureBoxSeeMore
            // 
            this.pictureBoxSeeMore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxSeeMore.BackgroundImage = global::FortuneMachine.Properties.Resources.question;
            this.pictureBoxSeeMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSeeMore.Location = new System.Drawing.Point(81, 50);
            this.pictureBoxSeeMore.Name = "pictureBoxSeeMore";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBoxSeeMore, 2);
            this.pictureBoxSeeMore.Size = new System.Drawing.Size(72, 85);
            this.pictureBoxSeeMore.TabIndex = 11;
            this.pictureBoxSeeMore.TabStop = false;
            // 
            // buttonChucNorrisFact
            // 
            this.buttonChucNorrisFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChucNorrisFact.BackgroundImage = global::FortuneMachine.Properties.Resources.chuck_norris;
            this.buttonChucNorrisFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonChucNorrisFact, 2);
            this.buttonChucNorrisFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChucNorrisFact.Location = new System.Drawing.Point(315, 252);
            this.buttonChucNorrisFact.Name = "buttonChucNorrisFact";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonChucNorrisFact, 2);
            this.buttonChucNorrisFact.Size = new System.Drawing.Size(150, 82);
            this.buttonChucNorrisFact.TabIndex = 12;
            this.buttonChucNorrisFact.TabStop = false;
            this.buttonChucNorrisFact.UseVisualStyleBackColor = true;
            this.buttonChucNorrisFact.Click += new System.EventHandler(this.buttonChucNorrisFact_Click);
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
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeeMore)).EndInit();
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
        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Button buttonAirQuality;
        private System.Windows.Forms.Button buttonReceipe;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.PictureBox pictureBoxFortuneTeller;
        private System.Windows.Forms.PictureBox pictureBoxSeeMore;
        private System.Windows.Forms.Button buttonChucNorrisFact;
    }
}

