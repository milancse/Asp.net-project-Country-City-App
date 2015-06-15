using System;
using System.Web.Services.Description;
using CountryAndCityApp.BLL;
using CountryAndCityApp.Model;

namespace CountryAndCityApp.UI
{
    public partial class CountryUi : System.Web.UI.Page
    {
        CountryManager aCountryManager=new CountryManager();
        Country aCountry=new Country();
        protected void Page_Load(object sender, EventArgs e)
        {
            displayCountryGridView.DataSource = aCountryManager.GetAllCountries();
            displayCountryGridView.DataBind();

        }

        protected void countrySaveButton_Click(object sender, EventArgs e)
        {
            aCountry.CountryName = countryNameTextBox.Text;
            aCountry.CountryAbout = countryAboutTextArea.InnerText;
            msgLabel.Text=aCountryManager.SaveCountry(aCountry);
            displayCountryGridView.DataSource = aCountryManager.GetAllCountries();
            displayCountryGridView.DataBind();
        }

       
    }
}