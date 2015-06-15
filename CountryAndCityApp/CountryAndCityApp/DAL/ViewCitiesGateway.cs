using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.DAL
{
    public class ViewCitiesGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CountryConnectionString"].ConnectionString;
    
        public List<City> GetAllCities()
        {
            List<City> cityList = new List<City>();
            string query = "SELECT *FROM  tbl_city INNER JOIN tbl_country ON tbl_country.Id=tbl_city.CountryId ";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
           
            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["Id"];
                aCity.CityName = Convert.ToString(aReader["CityName"]);
                aCity.CityAbout = Convert.ToString(aReader["CityAbout"]);
                aCity.NoOfDwellers = Convert.ToInt32(aReader["NoOfDwellers"]);
                aCity.Location = Convert.ToString(aReader["Location"]);
                aCity.Weather = Convert.ToString(aReader["Weather"]);
                //aCity.CountryId = Convert.ToInt32(aReader["CountryId"]);
                //int CountryId = Convert.ToInt32(aReader["CountryId"]);
                aCity.CountryName = Convert.ToString(aReader["CountryName"]);
                aCity.CountryAbout = Convert.ToString(aReader["CountryAbout"]);
                cityList.Add(aCity);
            }

            aReader.Close();
            aConnection.Close();
            return cityList;
        }

        public List<City> GetAllSearchedCities(string searchedCityName)
        {
            List<City> cityList = new List<City>();
            string query = "SELECT *FROM  tbl_city INNER JOIN tbl_country ON tbl_country.Id=tbl_city.CountryId WHERE CityName LIKE '%" + searchedCityName + "%'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["Id"];
                aCity.CityName = Convert.ToString(aReader["CityName"]);
                string cityAbout = Convert.ToString(aReader["CityAbout"]);
                aCity.CityAbout = StripHTML(cityAbout);
                aCity.NoOfDwellers = Convert.ToInt32(aReader["NoOfDwellers"]);
                aCity.Location = Convert.ToString(aReader["Location"]);
                aCity.Weather = Convert.ToString(aReader["Weather"]);
                //aCity.CountryId = Convert.ToInt32(aReader["CountryId"]);
                //int CountryId = Convert.ToInt32(aReader["CountryId"]);
                aCity.CountryName = Convert.ToString(aReader["CountryName"]);
                string countryAbout = Convert.ToString(aReader["CountryAbout"]);
                aCity.CountryAbout = StripHTML(countryAbout);
                cityList.Add(aCity);
            }

            aReader.Close();
            aConnection.Close();
            return cityList;
        }


        public List<City> GetAllSearchedCountries(int selectedCountry)
        {
            List<City> cityList = new List<City>();
            string query = "SELECT *FROM  tbl_city INNER JOIN tbl_country ON tbl_country.Id=tbl_city.CountryId WHERE tbl_city.CountryId = '" + selectedCountry + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                City aCity = new City();
                aCity.Id = (int)aReader["Id"];
                aCity.CityName = Convert.ToString(aReader["CityName"]);
                string cityAbout = Convert.ToString(aReader["CityAbout"]);
                aCity.CityAbout = StripHTML(cityAbout);
                aCity.NoOfDwellers = Convert.ToInt32(aReader["NoOfDwellers"]);
                aCity.Location = Convert.ToString(aReader["Location"]);
                aCity.Weather = Convert.ToString(aReader["Weather"]);
                //aCity.CountryId = Convert.ToInt32(aReader["CountryId"]);
                //int CountryId = Convert.ToInt32(aReader["CountryId"]);
                aCity.CountryName = Convert.ToString(aReader["CountryName"]);
                string countryAbout = Convert.ToString(aReader["CountryAbout"]);
                aCity.CountryAbout = StripHTML(countryAbout);
                cityList.Add(aCity);
            }

            aReader.Close();
            aConnection.Close();
            return cityList;
        }
        private string StripHTML(string source)
        {

            string result;

            // Remove HTML Development formatting
            // Replace line breaks with space
            // because browsers inserts space
            result = source.Replace("\r", " ");
            // Replace line breaks with space
            // because browsers inserts space
            result = result.Replace("\n", " ");
            // Remove step-formatting
            result = result.Replace("\t", string.Empty);
            // Remove repeating spaces because browsers ignore them
            result = System.Text.RegularExpressions.Regex.Replace(result,
                                                                  @"( )+", " ");

            // Remove the header (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*head([^>])*>", "<head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*head( )*>)", "</head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<head>).*(</head>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // remove all scripts (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*script([^>])*>", "<script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*script( )*>)", "</script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            //result = System.Text.RegularExpressions.Regex.Replace(result,
            //         @"(<script>)([^(<script>\.</script>)])*(</script>)",
            //         string.Empty,
            //         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<script>).*(</script>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // remove all styles (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*style([^>])*>", "<style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*style( )*>)", "</style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<style>).*(</style>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert tabs in spaces of <td> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*td([^>])*>", "\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert line breaks in places of <BR> and <LI> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*br( )*>", "\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*li( )*>", "\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert line paragraphs (double line breaks) in place
            // if <P>, <DIV> and <TR> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*div([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*tr([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*p([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // Remove remaining tags like <a>, links, images,
            // comments etc - anything that's enclosed inside < >
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<[^>]*>", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // replace special characters:
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @" ", " ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&bull;", " * ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&lsaquo;", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&rsaquo;", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&trade;", "(tm)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&frasl;", "/",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&lt;", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&gt;", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&copy;", "(c)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&reg;", "(r)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove all others. More can be added, see
            // http://hotwired.lycos.com/webmonkey/reference/special_characters/
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&(.{2,6});", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // for testing
            //System.Text.RegularExpressions.Regex.Replace(result,
            //       this.txtRegex.Text,string.Empty,
            //       System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // make line breaking consistent
            result = result.Replace("\n", "\r");

            // Remove extra line breaks and tabs:
            // replace over 2 breaks with 2 and over 4 tabs with 4.
            // Prepare first to remove any whitespaces in between
            // the escaped characters and remove redundant tabs in between line breaks
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)( )+(\r)", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\t)( )+(\t)", "\t\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\t)( )+(\r)", "\t\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)( )+(\t)", "\r\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove redundant tabs
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)(\t)+(\r)", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove multiple tabs following a line break with just one tab
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)(\t)+", "\r\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Initial replacement target string for line breaks
            string breaks = "\r\r\r";
            // Initial replacement target string for tabs
            string tabs = "\t\t\t\t\t";
            for (int index = 0; index < result.Length; index++)
            {
                result = result.Replace(breaks, "\r\r");
                result = result.Replace(tabs, "\t\t\t\t");
                breaks = breaks + "\r";
                tabs = tabs + "\t";
            }

            // That's it.
            return result;


        }
        
    }
}