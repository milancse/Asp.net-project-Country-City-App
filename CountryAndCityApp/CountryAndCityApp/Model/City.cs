using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryAndCityApp.Model
{
    public class City
    {
        public int Id { set; get; }
        public string CityName { set; get; }
        public string CityAbout { set; get; }
        public int NoOfDwellers  { set; get; }

        public string Location { set; get; }
        public string Weather { set; get; }
        public int CountryId { set; get; }
        public string CountryName { set; get; }
        public string CountryAbout { set; get; }
        //public Country CountryName { get; set; }





    }
}