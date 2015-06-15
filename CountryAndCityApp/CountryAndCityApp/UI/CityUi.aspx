<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityUi.aspx.cs" Inherits="CountryAndCityApp.UI.CityUi" validateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link href="../style.css" rel="stylesheet" />
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
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
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="cityNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="About"></asp:Label>
        <textarea id="cityAboutTextArea" cols="20" name="S1" rows="2" runat="server"></textarea><br />
        <asp:Label ID="Label3" runat="server" Text="No of Dwellers"></asp:Label>
        <asp:TextBox ID="noOfDwellersTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
        <asp:TextBox ID="locationTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Weather"></asp:Label>
        <asp:TextBox ID="weatherTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Country"></asp:Label>
        <asp:DropDownList ID="countryDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="CountryName" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CountryAndCityDBConnectionString %>" SelectCommand="SELECT [CountryName], [Id] FROM [tbl_country] ORDER BY [CountryName]"></asp:SqlDataSource>
        <asp:Button ID="citySaveButton" runat="server" OnClick="citySaveButton_Click" Text="Save" />
        <asp:Button ID="cityCancelButton" runat="server" Text="Cancel" />
        <br />
        <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Serial No" SortExpression="Id" />
                <asp:BoundField DataField="CityName" HeaderText="City Name" SortExpression="CityName" />
                <asp:BoundField DataField="NoOfDwellers" HeaderText="No Of Dwellers" SortExpression="NoOfDwellers" />
                <asp:BoundField DataField="CountryName" HeaderText="Country Name" SortExpression="CountryName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CountryAndCityDBConnectionString %>" SelectCommand="SELECT [Id], [CityName], [NoOfDwellers], [CountryId] FROM [tbl_city]"></asp:SqlDataSource>
        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
        <br />
    
    </article>
    </form>
      </section>
         <footer>
            Design & Developed by: bug coders
        </footer>
     </div>
    <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../froala_editor_1.2.7/js/froala_editor.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/tables.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/lists.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_family.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_size.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/video.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/colors.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/media_manager.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/block_styles.min.js"></script>
     <script>
         $(function () {
             $('#cityAboutTextArea').editable({ inlineMode: false, alwaysBlank: true })
         });
  </script>
        
</body>
</html>
