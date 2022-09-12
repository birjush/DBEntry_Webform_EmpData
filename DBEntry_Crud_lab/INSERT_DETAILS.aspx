<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="INSERT_DETAILS.aspx.cs" Inherits="DBEntry_Crud_lab.INSERT_DETAILS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">ID :</asp:Label>        <asp:TextBox runat="server" ID="Textbox1" ></asp:TextBox>
            <asp:Label runat="server">NAME :</asp:Label>     <asp:TextBox runat="server" ID="Textbox2" ></asp:TextBox>
            <asp:Label runat="server">CITY :</asp:Label>     <asp:TextBox runat="server" ID="Textbox3" ></asp:TextBox>
            <asp:Label runat="server">BOD :</asp:Label>     <asp:TextBox runat="server" type="date" ID="Textbox4" ></asp:TextBox>
            <asp:button ID="subBtn" runat="server" Text="submit" OnClick="subBtn_Click"/>


        </div>
    </form>
</body>
</html>
