<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryAndCityApp.UI.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="wrapper">
         <header>
            <h1>Country & City Info Zone</h1>
        </header>
         <nav>
            <ul>
                <li><a href="index.aspx">Home</a></li>
                <li><a href="CountryUi.aspx">Enter your country</a></li>
                <li><a href="CityUi.aspx">Enter your City</a></li>
                <li><a href="ViewCountry.aspx">View Country Info</a></li>
                <li><a href="ViewCities.aspx">View City Info</a></li>
            </ul>
         </nav>
        <section>
    <form id="form1" runat="server">
    <fieldset>
        <legend>Search Criteria</legend>  
        <article>
            <asp:Label ID="Label1" runat="server"  Text="View Cities"></asp:Label>
            <br />
          
        </article>
            <p>
            <asp:RadioButton ID="cityRadioButton" runat="server"  Text="City Name" GroupName="search" Checked="True"/>
                <asp:TextBox ID="citySearchTextBox" runat="server" style="margin-left: 12px"></asp:TextBox>
            </p>
            <asp:RadioButton ID="countryRadioButton" runat="server" Text="Country " GroupName="search" />
            <asp:DropDownList ID="countryDropDownList" runat="server" DataSourceID="SqlDataSource2" DataTextField="CountryName" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CountryAndCityDBConnectionString %>" SelectCommand="SELECT [Id], [CountryName] FROM [tbl_country] ORDER BY [CountryName]"></asp:SqlDataSource>
            <asp:Button ID="searchCityCountryButton" runat="server" style="margin-left: 40px" Text="Search" OnClick="searchCityCountryButton_Click" />
            <asp:GridView ID="displayCityGridView" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="CityName" HeaderText="City Name" SortExpression="CityName" />
                    <asp:BoundField DataField="CityAbout" HeaderText="City About" SortExpression="CityAbout" />
                    <asp:BoundField DataField="NoOfDwellers" HeaderText="No Of Dwellers" SortExpression="NoOfDwellers" />
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    <asp:BoundField DataField="Weather" HeaderText="Weather" SortExpression="Weather" />
                    <asp:BoundField DataField="CountryName" HeaderText="Country" SortExpression="CountryName" />
                    <asp:BoundField DataField="CountryAbout" HeaderText="Country About" SortExpression="CountryAbout" />
                </Columns>
        </asp:GridView>
        </fieldset>
    </form>
      </section>
         <footer>
            Design & Developed by: bug coders
        </footer>
     </div>
</body>
</html>
