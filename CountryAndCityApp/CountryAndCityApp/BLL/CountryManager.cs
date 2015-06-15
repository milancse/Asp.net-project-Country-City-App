using System.Web.Services.Description;
using CountryAndCityApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryAndCityApp.UI;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.BLL
{
    public class CountryManager
    {
        CountryDb aCountryDb=new CountryDb();

        public string SaveCountry(Country aCountry)
        {
           
            int countryCheck = aCountryDb.CountryExits(aCountry.CountryName);
            if (countryCheck > 0)
            {
                return "Country name already exist!";
            }
            else
            {
                string saveMessage=aCountryDb.SaveCountry(aCountry);
                return saveMessage;
            }
        }

        public List<Country> GetAllCountries()
        {
            return aCountryDb.GetAllCountries();
        }
        public List<Country> GetAllSearchedCountries(string searchedCountry)
        {
            return aCountryDb.GetAllSearchedCountries(searchedCountry);
        }
    }
}