<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountry.aspx.cs" Inherits="CountryAndCityApp.UI.ViewCountry" %>

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
    <article>
    
        <asp:Label ID="Label1" runat="server" Text="View Country"></asp:Label>
    
    </article>
        <fieldset>
            <legend>Search Criteria</legend>
       
        <p>
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="searchCountryTextBox" runat="server" style="margin-left: 21px" Width="149px"></asp:TextBox>
            <asp:Button ID="searchOnlyCountryButton" runat="server" style="margin-left: 23px" Text="Search" OnClick="searchOnlyCountryButton_Click" />
        </p>
            
        <asp:GridView ID="countryGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Serial No" SortExpression="Id" />
                <asp:BoundField DataField="CountryName" HeaderText="Country Name" SortExpression="CountryName" />
                <asp:BoundField DataField="CountryAbout" HeaderText="About Country" SortExpression="CountryAbout" />
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
