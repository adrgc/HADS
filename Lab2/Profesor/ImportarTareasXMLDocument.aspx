<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImportarTareasXMLDocument.aspx.cs" Inherits="Lab2.ImportarTareasXMLDocument" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 468px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td colspan="2" bgcolor="#3399cc" align="center">
                        <asp:Label ID="Label1" runat="server" Text="PROFESOR"></asp:Label>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="IMPORTAR TAREAS GENERICAS"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td style="width: 50%">

                        <asp:Label ID="Label3" runat="server" Text="Seleccionar Asignatura a Importar"></asp:Label>
                        <br />
                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS21-11aConnectionString %>" SelectCommand="SELECT GruposClase.codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (ProfesoresGrupo.email = @email)">
                            <SelectParameters>
                                <asp:SessionParameter Name="email" SessionField="email" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />
                        <br />
                        <br />
                        Ordenar por:<br />
                        <br />
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            <asp:ListItem>Codigo</asp:ListItem>
                            <asp:ListItem>Descripcion</asp:ListItem>
                            <asp:ListItem>HEstimadas</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Height="35px" Text="IMPORTAR (XMLD)" Width="200px" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Profesor.aspx">Menu Profesor</asp:HyperLink>

                    </td>
                    <td class="auto-style3">

                        <asp:Xml ID="Xml1" runat="server"></asp:Xml>

                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
