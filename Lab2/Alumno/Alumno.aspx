<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="Lab2.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 66px;
        }
        .auto-style2 {
            height: 553px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table border=1 width=100% class="auto-style1">
<tr>
<td colspan=2 bgcolor="#3399cc" align=center class="auto-style3"><h1> <asp:Label ID="Label3" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label></h1></td>
</tr>
<tr>
<td width=20% bgcolor="#3399cc"  class="auto-style2">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="TareasAlumno.aspx">Tareas Genericas</asp:HyperLink>
   
    <br />
    <asp:HyperLink ID="HyperLink2" runat="server">Tareas Propias</asp:HyperLink>
    <br />
    <asp:HyperLink ID="HyperLink3" runat="server">Grupos</asp:HyperLink>
    <br />
   
    </td>
<td align=center valign=middle class="auto-style2">
    <asp:Label ID="Label1" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Alumnos"></asp:Label>
    </td>
</tr>
</table>
        </div>
    </form>
</body>
</html>
