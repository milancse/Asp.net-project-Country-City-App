<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CountryAndCityApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="../style.css" rel="stylesheet" />
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
    Get information about cities or countries. 
        Or add by yourself ..... 
    </article>
    </form>
              </section>
        <footer>
            Design & Developed by: bug coders
        </footer>
     </div>
</body>
</html>
