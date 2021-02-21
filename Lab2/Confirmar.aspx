<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmar.aspx.cs" Inherits="Lab2.Confirmar" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Style.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }
        .auto-style2 {
            width: 173px;
        }
    </style>
</head>
<body >
    <h1 class="Title">CONFIRMAR REGISTRO</h1>
    <form id="form1" runat="server">
        
            
        <h1><asp:Label ID="error" runat="server" Text=""></asp:Label></h1>
         <h1><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="Login.aspx"><asp:Label ID="confirmar" runat="server" Text=""></asp:Label></asp:HyperLink></h1>
        
            

    </form>
</body>
</html>