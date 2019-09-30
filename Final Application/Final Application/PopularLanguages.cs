using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Application
{
    public class PopularLanguages
    {
        //Members
        public const int ITEMS = 4;
        public const int ITEMSIZE = 3;
        public string[,] countries = new string[ITEMS, ITEMSIZE];
        public int index;

        //Constructor
        public PopularLanguages()
        {
            InitializeCountries();
        }


        //Properties
        public string[,] Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        //2D Array of Country set
        public string[,] InitializeCountries()
        {
            string[,] countries = new string[,]
            {
                {"United States", "United Kingdom", "Canada" },
                {"China", "Taiwan", "Singapore" },
                {"Russia", "Belarus", "Kazakhstan" },
                {"Germany", "Austria", "Switzerland" },
            };
            Countries = countries;
            return Countries;
        }
    }
}
