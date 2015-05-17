<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsToWCF.aspx.cs" Inherits="Sample_WCF.DetailsToWCF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <input type="text" runat="server" id="Fname"/>
     <input type="text" runat="server" id="Lname"/>
        
     <asp:Button runat="server" id="Calculate" OnClick="Display_result" />

        <asp:label id="result" runat="server" Text="Ans"></asp:label>
    </div>
    </form>
</body>
</html>
