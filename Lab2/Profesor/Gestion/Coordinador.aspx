<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinador.aspx.cs" Inherits="Lab2.Profesor.Gestion.Coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>

                <table border="1" width="100%">
                    <tr>
                        <td bgcolor="#3399cc" align="center">
                            <asp:Label ID="Label5" runat="server" Text="COORDINADOR"></asp:Label>
                            <br />
                            <asp:Label ID="Label6" runat="server" Text="VISUALIZAR DEDICACION MEDIA POR ASIGNATURA"></asp:Label></td>
                        <td bgcolor="#3399cc" width="12%">
                            <asp:Button ID="Button3" runat="server" Height="26px" Text="Cerrar sesion" OnClick="Button3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">

                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>

                            <br />
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Label ID="Label7" runat="server" Text="Seleccione una asignatura:   "></asp:Label>
                                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
                                    </asp:DropDownList>
                                    <br />
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
                                    <asp:Label ID="Label8" runat="server" Text="La media de horas dedicadas a las tareas de esta asignatura es: "></asp:Label>
                                    <asp:Label ID="HR" runat="server"></asp:Label>
                                    <br />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <br />
                            <br />

                            <br />
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="../Profesor.aspx">Menu Profesor</asp:HyperLink>

                            <br />

                        </td>

                    </tr>
                </table>


                <br />
            </div>
        </div>
    </form>
</body>
</html>
