using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryAndCityApp.DAL;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.BLL
{
    public class CityManager
    {
        CityDb aCityDb=new CityDb();

        public string SaveCity(City aCity)
        {
            int checkCity = aCityDb.CityExits(aCity.CityName);
            if (checkCity>0)
            {
                return "City Exists!!!!";
            }
            else
            {
                return aCityDb.SaveCity(aCity);
            }

        }
       public List<City> GetAllCities()
        {
            return aCityDb.GetAllCities();
        }
    }
}