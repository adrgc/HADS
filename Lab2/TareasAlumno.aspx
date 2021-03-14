<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TareasAlumno.aspx.cs" Inherits="Lab2.TareasAlumno" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border=1 width=100%  >
<tr>
<td  bgcolor="#3399cc" align=center > <asp:Label ID="Label5" runat="server" Text="ALUMNO"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label></td>
    <td width=12% bgcolor="#3399cc"  > <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cerrar Sesion" Width="138px" /> </td>
</tr>
<tr>
<td colspan =2   >
     
            <asp:DropDownList ID="asignaturasList" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
       
        <asp:GridView ID="table" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="725px" OnSelectedIndexChanged="table_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                       <asp:Button ID="instanciarBoton"  runat="server" Text="Instanciar" CommandArgument='<%# Eval("Codigo") %>' OnClick="instanciarBoton_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="HEstimadas" HeaderText="Horas" />
                <asp:BoundField DataField="TipoTarea" HeaderText="Tipo" />
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
   
            <asp:Label ID="Label7" runat="server"></asp:Label>
   
    </td>

</tr>
</table>
        </div>
    </form>
</body>
</html>
