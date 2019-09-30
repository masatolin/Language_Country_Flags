using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Application
{
    public partial class countryByLanguage : Form
    {
        //Members
        const int READSIZE = 3;
        private int index;
        private string countryName;
        private PopularLanguages popularLanguages;
        private CountryImage countryImage;

        //Properties
        public PopularLanguages LanguageList
        {
            get { return popularLanguages; }
            set { popularLanguages = value; }
        }
        public CountryImage ImageName
        {
            get { return countryImage; }
            set { countryImage = value; }
        }

        //Constructor
        public countryByLanguage()
        {
            InitializeComponent();
            PopularLanguages popularLanguages = new PopularLanguages();
            LanguageList = popularLanguages;

            CountryImage countryImage = new CountryImage();
            ImageName = countryImage;

        }

        //disables the disable the past button if the option has no past flag
        private void toggleSecretButton()
        {
            if (countryName.Equals("United States") || countryName.Equals("China") || countryName.Equals("Russia") || countryName.Equals("Germany"))
            {
                bonusButton.Enabled = true;
            }
            else
            {
                bonusButton.Enabled = false;
            }
        }

        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //sets index to a selected item on combobox
                index = this.languagesComboBox.SelectedIndex;
                //clears list box
                countriesListBox.Items.Clear();
                //fills the list box with countries from array
                for (int i = 0; i < READSIZE; i++)
                {
                    countriesListBox.Items.Add(LanguageList.Countries[index, i]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //set variable to selected Listbox item
                countryName = countriesListBox.Items[countriesListBox.SelectedIndex].ToString();
                //gets image name
                string country = ImageName.ImageFiles[countryName];
                //sets background images to flag
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(country);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        toggleSecretButton();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //It's an exit button dummy
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            try
            {
                //pulls out past flag if it is first foud countries of each language
                if (countryName.Equals("United States") || countryName.Equals("China") || countryName.Equals("Russia") || countryName.Equals("Germany"))
                {

                    Dictionary<string, string> secretFlags = new Dictionary<string, string>();
                    secretFlags.Add("United States", "US_Betsy_Ross_Flag1");
                    secretFlags.Add("China", "Chinese_Empire_Flag1");
                    secretFlags.Add("Russia", "USSR_Flag1");
                    secretFlags.Add("Germany", "German_Empire_Flag1");

                    string oldCountry = secretFlags[countryName];
                    this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(oldCountry);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
