using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Application
{
    public class CountryImage
    {

        //Members
        private Dictionary<string,string> imageFiles;

        //Properties
        public Dictionary<string, string> ImageFiles
        {
            get { return imageFiles; }
            set { imageFiles = value; }
        }

        //Constructor
        public CountryImage()
        {
            InitializeFlags();
        }

        public void InitializeFlags()
        {
            //Dictionary (string array)
            Dictionary<string, string> imageFiles = new Dictionary<string, string>();
            imageFiles.Add("United States", "US_Flag1");
            imageFiles.Add("United Kingdom", "UK_Flag1");
            imageFiles.Add("Canada", "Canada_Flag1");
            imageFiles.Add("China", "China_Flag1");
            imageFiles.Add("Taiwan", "Taiwan_Flag1");
            imageFiles.Add("Singapore", "Singapore_Flag1");
            imageFiles.Add("Russia", "Russia_Flag1");
            imageFiles.Add("Belarus", "Belarus_Flag1");
            imageFiles.Add("Kazakhstan", "Kazakhstan_Flag1");
            imageFiles.Add("Germany", "Germany_Flag1");
            imageFiles.Add("Austria", "Austria_Flag1");
            imageFiles.Add("Switzerland", "Switzerland_Flag1");
            ImageFiles = imageFiles;
        }
    }
}
