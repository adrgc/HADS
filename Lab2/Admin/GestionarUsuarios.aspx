<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarUsuarios.aspx.cs" Inherits="Lab2.Admin.GestionarUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td bgcolor="#3399cc" align="center">
                        <asp:Label ID="Label5" runat="server" Text="ADMINISTRADOR"></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text="GESTIONAR USUARIOS"></asp:Label></td>
                    <td bgcolor="#3399cc" width="12%">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cerrar Sesion" Width="138px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                       

                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="email" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                                <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                                <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                                <asp:CheckBoxField DataField="confirmado" HeaderText="confirmado" SortExpression="confirmado" />
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
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" DeleteCommand="DELETE FROM [Usuarios] WHERE [email] = @original_email AND [nombre] = @original_nombre AND [apellidos] = @original_apellidos AND [tipo] = @original_tipo AND [confirmado] = @original_confirmado" InsertCommand="INSERT INTO [Usuarios] ([email], [nombre], [apellidos], [tipo], [confirmado]) VALUES (@email, @nombre, @apellidos, @tipo, @confirmado)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [email], [nombre], [apellidos], [tipo], [confirmado] FROM [Usuarios] WHERE ([email] &lt;&gt; @email)" UpdateCommand="UPDATE [Usuarios] SET [nombre] = @nombre, [apellidos] = @apellidos, [tipo] = @tipo, [confirmado] = @confirmado WHERE [email] = @original_email AND [nombre] = @original_nombre AND [apellidos] = @original_apellidos AND [tipo] = @original_tipo AND [confirmado] = @original_confirmado">
                            <DeleteParameters>
                                <asp:Parameter Name="original_email" Type="String" />
                                <asp:Parameter Name="original_nombre" Type="String" />
                                <asp:Parameter Name="original_apellidos" Type="String" />
                                <asp:Parameter Name="original_tipo" Type="String" />
                                <asp:Parameter Name="original_confirmado" Type="Boolean" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="email" Type="String" />
                                <asp:Parameter Name="nombre" Type="String" />
                                <asp:Parameter Name="apellidos" Type="String" />
                                <asp:Parameter Name="tipo" Type="String" />
                                <asp:Parameter Name="confirmado" Type="Boolean" />
                            </InsertParameters>
                            <SelectParameters>
                                <asp:SessionParameter Name="email" SessionField="email" Type="String" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="nombre" Type="String" />
                                <asp:Parameter Name="apellidos" Type="String" />
                                <asp:Parameter Name="tipo" Type="String" />
                                <asp:Parameter Name="confirmado" Type="Boolean" />
                                <asp:Parameter Name="original_email" Type="String" />
                                <asp:Parameter Name="original_nombre" Type="String" />
                                <asp:Parameter Name="original_apellidos" Type="String" />
                                <asp:Parameter Name="original_tipo" Type="String" />
                                <asp:Parameter Name="original_confirmado" Type="Boolean" />
                            </UpdateParameters>
                        </asp:SqlDataSource>

                        <br />

                        <br />

                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
