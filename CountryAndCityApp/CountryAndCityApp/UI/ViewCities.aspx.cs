using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryAndCityApp.BLL;

namespace CountryAndCityApp.UI
{
    public partial class ViewCities : System.Web.UI.Page
    {
        ViewCitiesManager aViewCitiesManager=new ViewCitiesManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            displayCityGridView.DataSource = aViewCitiesManager.GetAllCities();
            displayCityGridView.DataBind();
        }

        protected void searchCityCountryButton_Click(object sender, EventArgs e)
        {
            bool chckCityRadioButton = cityRadioButton.Checked;
            bool chckCountryRadioButton = countryRadioButton.Checked;
            int selectedCountry = Convert.ToInt32(countryDropDownList.SelectedValue);
            //string selectedCountry = countryDropDownList.DataTextField;
            string searchedCityName = citySearchTextBox.Text;
            displayCityGridView.DataSource = aViewCitiesManager.GetAllSearchedCities(chckCityRadioButton, chckCountryRadioButton, selectedCountry, searchedCityName);
            displayCityGridView.DataBind();

        }

       
    }
}