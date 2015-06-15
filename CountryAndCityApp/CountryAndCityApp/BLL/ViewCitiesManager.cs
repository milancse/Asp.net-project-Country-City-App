using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryAndCityApp.DAL;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.BLL
{
    public class ViewCitiesManager
    {
        ViewCitiesGateway aViewCitiesGateway=new ViewCitiesGateway();

        public List<City> GetAllCities()
        {
            return aViewCitiesGateway.GetAllCities();
        }

        public List<City> GetAllSearchedCities(bool chckCityRadioButton, bool chckCountryRadioButton, int selectedCountry, string searchedCityName)
        {
            if (chckCityRadioButton == true)
            {
                return aViewCitiesGateway.GetAllSearchedCities(searchedCityName);
            }
            else
            {
                return aViewCitiesGateway.GetAllSearchedCountries(selectedCountry);
            }
        }
    }

}