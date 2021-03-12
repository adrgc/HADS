<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarTarea.aspx.cs" Inherits="Lab2.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
            width: 293px;
        }
        .auto-style2 {
            height: 23px;
            width: 160px;
        }
        .auto-style3 {
            width: 160px;
        }
        .auto-style4 {
            width: 293px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="PROFESOR"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server">CERRAR SESION</asp:HyperLink>
            <br />
            <br />
            <br />
        </div>
         <div>
             <table >
                 <tr>
                     <td class="auto-style2">
                         <asp:Label ID="Label3" runat="server" Text="Codigo"></asp:Label>
                     </td>
                     <td class="auto-style1">
                         <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
                     </td>
                     
                 </tr>
                 <tr>
                     <td class="auto-style3">
                         <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
                     </td>
                     <td class="auto-style4">
                         <asp:TextBox ID="TextBox2" runat="server" Height="88px" Width="290px" TextMode="MultiLine"></asp:TextBox>
                     </td>
                   
                 </tr>
                 <tr>
                     <td class="auto-style3">
                         <asp:Label ID="Label5" runat="server" Text="Asignatura"></asp:Label>
                     </td>
                     <td class="auto-style4">
                         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
                         </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
                     </td>
                 </tr>
                   <tr>
                     <td class="auto-style3">
                         <asp:Label ID="Label6" runat="server" Text="Horas Estimadas"></asp:Label>
                       </td>
                     <td class="auto-style4">
                         <asp:TextBox ID="TextBox3" runat="server" Width="79px" TextMode="Number"></asp:TextBox>
                       </td>
                 </tr>
                   <tr>
                     <td class="auto-style3">
                         <asp:Label ID="Label7" runat="server" Text="Tipo Tarea"></asp:Label>
                       </td>
                     <td class="auto-style4">
                         <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="TipoTarea" DataValueField="TipoTarea">
                         </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT DISTINCT [TipoTarea] FROM [TareasGenericas]"></asp:SqlDataSource>
                       </td>
                 </tr>
                   <tr>
                     <td class="auto-style3">&nbsp;</td>
                     <td class="auto-style4">&nbsp;</td>
                 </tr>
             </table>
    </div>
    </form>
   
</body>
</html>
