namespace Final_Application
{
    partial class countryByLanguage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.bonusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Items.AddRange(new object[] {
            "English",
            "Chinese",
            "Russian",
            "German"});
            this.languagesComboBox.Location = new System.Drawing.Point(15, 37);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.Size = new System.Drawing.Size(99, 21);
            this.languagesComboBox.TabIndex = 0;
            this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(352, 37);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(120, 43);
            this.countriesListBox.TabIndex = 1;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(93, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(12, 17);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(110, 13);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Select Language First";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(356, 17);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(116, 13);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Select Country Second";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bonusButton
            // 
            this.bonusButton.Enabled = false;
            this.bonusButton.Location = new System.Drawing.Point(174, 261);
            this.bonusButton.Name = "bonusButton";
            this.bonusButton.Size = new System.Drawing.Size(78, 23);
            this.bonusButton.TabIndex = 6;
            this.bonusButton.Text = "Bonus Flag";
            this.bonusButton.UseVisualStyleBackColor = true;
            this.bonusButton.Click += new System.EventHandler(this.bonusButton_Click);
            // 
            // countryByLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 296);
            this.Controls.Add(this.bonusButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.languagesComboBox);
            this.Name = "countryByLanguage";
            this.Text = "Country Flags By What Language They Speak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languagesComboBox;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button bonusButton;
    }
}

