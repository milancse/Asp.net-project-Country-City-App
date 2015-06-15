using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryAndCityApp.BLL;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.UI
{
    public partial class CityUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cityGridView.DataSource = aCityManager.GetAllCities();
            cityGridView.DataBind();

        }
        CityManager aCityManager=new CityManager();
        
        protected void citySaveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();

            aCity.CityName = cityNameTextBox.Text;
            aCity.CityAbout = cityAboutTextArea.InnerText;
            aCity.NoOfDwellers = Convert.ToInt32(noOfDwellersTextBox.Text);
            aCity.Location = locationTextBox.Text;
            aCity.Weather = weatherTextBox.Text;

            aCity.CountryId = Convert.ToInt32(countryDropDownList.SelectedValue);
            msgLabel.Text=aCityManager.SaveCity(aCity);

            cityGridView.DataSource = aCityManager.GetAllCities();
            cityGridView.DataBind();




        }
    }
}