<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarTarea.aspx.cs" Inherits="Lab2.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">

        <table border=1 width=100% >
<tr>
<td  bgcolor="#3399cc" align=center > <asp:Label ID="Label1" runat="server" Text="PROFESOR"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label> </td>
    <td bgcolor="#3399cc" width=12% > <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cerrar Sesion" Width="138px" /> </td>
</tr>
<tr>
<td colspan =2  >
      <br />
      <table >
                 <tr>
                     <td >
                         <asp:Label ID="Label3" runat="server" Text="Codigo"></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                     </td>
                     
                 </tr>
                 <tr>
                     <td >
                         <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox2" runat="server" Height="88px" Width="290px" TextMode="MultiLine"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                     </td>
                   
                 </tr>
                 <tr>
                     <td >
                         <asp:Label ID="Label5" runat="server" Text="Asignatura"></asp:Label>
                     </td>
                     <td >
                         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
                         </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT GruposClase.codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (ProfesoresGrupo.email = @email)">
                             <SelectParameters>
                                 <asp:SessionParameter Name="email" SessionField="email" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                         <br />
                     </td>
                 </tr>
                   <tr>
                     <td >
                         <asp:Label ID="Label6" runat="server" Text="Horas Estimadas"></asp:Label>
                       </td>
                     <td >
                         <asp:TextBox ID="TextBox3" runat="server" Width="79px" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                       </td>
                 </tr>
                   <tr>
                     <td >
                         <asp:Label ID="Label7" runat="server" Text="Tipo Tarea"></asp:Label>
                       </td>
                     <td >
                         <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="TipoTarea" DataValueField="TipoTarea">
                         </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT DISTINCT [TipoTarea] FROM [TareasGenericas]"></asp:SqlDataSource>
                       </td>
                 </tr>
                   <tr>
                     <td colspan =2 >
                         <asp:Label ID="Label8" runat="server"></asp:Label>
                         <br />
                         <asp:Button ID="Button1" runat="server"  Text="Insertar Tarea" Width="267px" OnClick="Button1_Click" />

                         <br />

                         <br />

                         <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl ="TareasProfesor.aspx">Volver</asp:HyperLink>

                       </td>
                   
                 </tr>
             </table>
            
   
    </td>

</tr>
</table>
   
        
    </form>
   
</body>
</html>
