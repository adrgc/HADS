<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="Lab2.Profesorr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        <table border="1" width="100%" class="auto-style1">
            <tr>
                <td width="20%" bgcolor="#3399cc" align="center" class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cerrar sesión" />
                    <ajaxToolkit:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" ConfirmText="¿Está seguro de que quiere cerrar sesión?" TargetControlID="Button1" />
                </td>
                <td width="80%" bgcolor="#3399cc" align="center" class="auto-style3">
                    <h1>
                        <asp:Label ID="Label3" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label></h1>
                </td>

            </tr>
            <tr>
                <td width="20%" bgcolor="#3399cc" class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="TareasProfesor.aspx">Tareas</asp:HyperLink>

                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Gestion/ImportarTareasXMLDocument.aspx">Importar v. XMLDocument</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="Gestion/ImportarTareasDataSet.aspx">Importar v. DataSet (opcional)</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Gestion/ExportarTareas.aspx">Exportar</asp:HyperLink>
                    <br />

                </td>
                <td align="center" valign="middle" class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Gestion web de tareas - dedicacion"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Profesores"></asp:Label>
                    <br />
                    <asp:Timer ID="Timer1" runat="server" Interval="5000">
                    </asp:Timer>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="Label4" runat="server" Text="Alumnos conectados: "></asp:Label>
                            <asp:Label ID="alumnos" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Profesores conectados: "></asp:Label>
                            <asp:Label ID="profes" runat="server"></asp:Label>
                            <br />
                            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
