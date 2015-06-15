using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryAndCityApp.BLL;

namespace CountryAndCityApp.UI
{
    public partial class ViewCountry : System.Web.UI.Page
    {
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            countryGridView.DataSource = aCountryManager.GetAllCountries();
            countryGridView.DataBind();
        }

        protected void searchOnlyCountryButton_Click(object sender, EventArgs e)
        {
            string searchedCountry = searchCountryTextBox.Text;
            countryGridView.DataSource = aCountryManager.GetAllSearchedCountries(searchedCountry);
            countryGridView.DataBind();
        }
    }
}