<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstanciarTarea.aspx.cs" Inherits="Lab2.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   
    <style type="text/css">
        .auto-style1 {
            margin-left: 43px;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table border=1 width=100% >
<tr>
<td  bgcolor="#3399cc" align=center colspan=2 > <asp:Label ID="Label1" runat="server" Text="PROFESOR"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label> </td>
    <td width=12% bgcolor="#3399cc"  > 

        <asp:Button ID="Button2" runat="server"  OnClick="Button2_Click" Text="Cerrar Sesion" Width="138px" />
    </td>
</tr>
<tr>
<td width=65%>
      <br />
      <table >
                 <tr>
                     <td >
                         <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox1" runat="server" Width="290px" ReadOnly="True"></asp:TextBox>
                     </td>
                     
                 </tr>
                 <tr>
                   <td >
                         <asp:Label ID="Label4" runat="server" Text="Tarea"></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox2" runat="server" Width="290px" ReadOnly="True"></asp:TextBox>
                     </td>
                   
                 </tr>
                 <tr>
                     <td >
                         <asp:Label ID="Label5" runat="server" Text="Horas Est."></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox4" runat="server" Width="290px" ReadOnly="True"></asp:TextBox>
                     </td>
                 </tr>
                   <tr>
                     <td >
                         <asp:Label ID="Label6" runat="server" Text="Horas reales"></asp:Label>
                     </td>
                     <td >
                         <asp:TextBox ID="TextBox3" runat="server" Width="290px" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                   
                   <tr>
                     <td colspan =2>
                         <br />
                         <asp:Button ID="Button1" runat="server" Text="Crear Tarea" Width="267px" OnClick="Button1_Click" Height="31px" CssClass="auto-style1"  />

                         <br />

                         <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl ="TareasAlumno.aspx">Volver</asp:HyperLink>

                       </td>
                   
                 </tr>
             </table>
            
   
      <asp:Label ID="Label7" runat="server"></asp:Label>
            
   
    </td>
    <td colspan =2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="CodTarea" HeaderText="CodTarea" />
                <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" />
                <asp:BoundField DataField="HReales" HeaderText="HReales" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </td>
</tr>
</table>
        </div>
    </form>
</body>
</html>
