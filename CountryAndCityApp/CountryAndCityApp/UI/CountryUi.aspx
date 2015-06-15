<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryUi.aspx.cs" Inherits="CountryAndCityApp.UI.CountryUi" validateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Country Entry</title>
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
        <aside>

            <br />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="countryNameTextBox" runat="server"></asp:TextBox>

      </aside>
        <asp:Label ID="Label2" runat="server" Text="About"></asp:Label>
        <textarea id="countryAboutTextArea" cols="20" rows="2" runat="server"></textarea>
        <asp:Button ID="countrySaveButton" runat="server" OnClick="countrySaveButton_Click" Text="Save" />
        <asp:Button ID="countryCancelButton" runat="server" Text="Cancel" />
        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
        <asp:GridView ID="displayCountryGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="SL No." SortExpression="Id" />
                <asp:BoundField DataField="CountryName" HeaderText="Country Name" SortExpression="CountryName" />
                <asp:BoundField DataField="CountryAbout" HeaderText="CountryAbout" SortExpression="CountryAbout" />
            </Columns>
        </asp:GridView>
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
             $('#countryAboutTextArea').editable({ inlineMode: false, alwaysBlank: true })
         });
  </script>
        
</body>

</html>
