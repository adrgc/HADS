<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="Lab2.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 402px;
        }
        .auto-style2 {
            height: 496px;
        }
        .auto-style3 {
            height: 83px;
        }
    </style>
    </head>
<body style="height: 559px">
    <form id="form1" runat="server">
    <table border=1 width=100% class="auto-style1">
<tr>
<td colspan=2 bgcolor="#3399cc" align=center class="auto-style3"><h1> <asp:Label ID="Label3" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label></h1></td>
</tr>
<tr>
<td width=20% bgcolor="#3399cc"  class="auto-style2">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="TareasProfesor.aspx">Tareas</asp:HyperLink>
   
    <br />
    <asp:HyperLink ID="HyperLink2" runat="server">Importar v. XMLDocument</asp:HyperLink>
    <br />
    <asp:HyperLink ID="HyperLink3" runat="server">Exportar</asp:HyperLink>
    <br />
   
    </td>
<td align=center valign=middle class="auto-style2">
    <asp:Label ID="Label1" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Profesores"></asp:Label>
    </td>
</tr>
</table>
    </form>
    </body>
</html>
