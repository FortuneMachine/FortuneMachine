
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.tabPageChoices = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelChoices = new System.Windows.Forms.TableLayoutPanel();
            this.labelChoicesMessage = new System.Windows.Forms.Label();
            this.ChoicesSpacer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonWeather = new System.Windows.Forms.Button();
            this.buttonLove = new System.Windows.Forms.Button();
            this.buttonChuckNorris = new System.Windows.Forms.Button();
            this.buttonWink = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.tabPageSeeMore = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageChoices.SuspendLayout();
            this.tableLayoutPanelChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanelChoices.Controls.Add(this.labelChoicesMessage, 2, 1);
            this.tableLayoutPanelChoices.Controls.Add(this.ChoicesSpacer, 0, 2);
            this.tableLayoutPanelChoices.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWeather, 1, 4);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonChuckNorris, 4, 4);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWink, 7, 4);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonLove, 1, 7);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonMoney, 4, 7);
            this.tableLayoutPanelChoices.Controls.Add(this.buttonWork, 7, 7);
            this.tableLayoutPanelChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelChoices.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelChoices.Name = "tableLayoutPanelChoices";
            this.tableLayoutPanelChoices.RowCount = 10;
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelChoices.Size = new System.Drawing.Size(919, 485);
            this.tableLayoutPanelChoices.TabIndex = 0;
            // 
            // labelChoicesMessage
            // 
            this.labelChoicesMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChoicesMessage.AutoSize = true;
            this.tableLayoutPanelChoices.SetColumnSpan(this.labelChoicesMessage, 6);
            this.labelChoicesMessage.Location = new System.Drawing.Point(185, 64);
            this.labelChoicesMessage.Name = "labelChoicesMessage";
            this.labelChoicesMessage.Size = new System.Drawing.Size(540, 15);
            this.labelChoicesMessage.TabIndex = 0;
            this.labelChoicesMessage.Text = "Choisis l\'information que tu veux que je te prédise";
            this.labelChoicesMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoicesSpacer
            // 
            this.ChoicesSpacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoicesSpacer.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanelChoices.SetColumnSpan(this.ChoicesSpacer, 10);
            this.ChoicesSpacer.Location = new System.Drawing.Point(3, 119);
            this.ChoicesSpacer.Name = "ChoicesSpacer";
            this.ChoicesSpacer.Size = new System.Drawing.Size(913, 2);
            this.ChoicesSpacer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanelChoices.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(176, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonWeather
            // 
            this.buttonWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWeather, 2);
            this.buttonWeather.Location = new System.Drawing.Point(94, 195);
            this.buttonWeather.Name = "buttonWeather";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWeather, 2);
            this.buttonWeather.Size = new System.Drawing.Size(176, 90);
            this.buttonWeather.TabIndex = 3;
            this.buttonWeather.Text = "Meteo";
            this.buttonWeather.UseVisualStyleBackColor = true;
            this.buttonWeather.Click += new System.EventHandler(this.buttonWeather_Click);
            // 
            // buttonLove
            // 
            this.buttonLove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonLove, 2);
            this.buttonLove.Location = new System.Drawing.Point(94, 339);
            this.buttonLove.Name = "buttonLove";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonLove, 2);
            this.buttonLove.Size = new System.Drawing.Size(176, 90);
            this.buttonLove.TabIndex = 4;
            this.buttonLove.Text = "Amour Astro";
            this.buttonLove.UseVisualStyleBackColor = true;
            this.buttonLove.Click += new System.EventHandler(this.buttonLove_Click);
            // 
            // buttonChuckNorris
            // 
            this.buttonChuckNorris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonChuckNorris, 2);
            this.buttonChuckNorris.Location = new System.Drawing.Point(367, 195);
            this.buttonChuckNorris.Name = "buttonChuckNorris";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonChuckNorris, 2);
            this.buttonChuckNorris.Size = new System.Drawing.Size(176, 90);
            this.buttonChuckNorris.TabIndex = 5;
            this.buttonChuckNorris.Text = "Chuck Norris Fact";
            this.buttonChuckNorris.UseVisualStyleBackColor = true;
            this.buttonChuckNorris.Click += new System.EventHandler(this.buttonChuckNorris_Click);
            // 
            // buttonWink
            // 
            this.buttonWink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWink, 2);
            this.buttonWink.Location = new System.Drawing.Point(640, 195);
            this.buttonWink.Name = "buttonWink";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWink, 2);
            this.buttonWink.Size = new System.Drawing.Size(176, 90);
            this.buttonWink.TabIndex = 6;
            this.buttonWink.Text = "Clien d\'oeil Astro";
            this.buttonWink.UseVisualStyleBackColor = true;
            this.buttonWink.Click += new System.EventHandler(this.buttonWink_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonMoney, 2);
            this.buttonMoney.Location = new System.Drawing.Point(367, 339);
            this.buttonMoney.Name = "buttonMoney";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonMoney, 2);
            this.buttonMoney.Size = new System.Drawing.Size(176, 90);
            this.buttonMoney.TabIndex = 7;
            this.buttonMoney.Text = "Argent Astro";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChoices.SetColumnSpan(this.buttonWork, 2);
            this.buttonWork.Location = new System.Drawing.Point(640, 339);
            this.buttonWork.Name = "buttonWork";
            this.tableLayoutPanelChoices.SetRowSpan(this.buttonWork, 2);
            this.buttonWork.Size = new System.Drawing.Size(176, 90);
            this.buttonWork.TabIndex = 8;
            this.buttonWork.Text = "Travail Astro";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
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
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Interface";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageChoices.ResumeLayout(false);
            this.tableLayoutPanelChoices.ResumeLayout(false);
            this.tableLayoutPanelChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonWeather;
        private System.Windows.Forms.Button buttonLove;
        private System.Windows.Forms.Button buttonChuckNorris;
        private System.Windows.Forms.Button buttonWink;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonWork;
    }
}

