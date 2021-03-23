<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarPassword.aspx.cs" Inherits="Lab2.CambiarPassword" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }

        .auto-style2 {
            width: 173px;
        }

        .auto-style3 {
            width: 173px;
            height: 24px;
        }

        .auto-style4 {
            width: 240px;
            height: 24px;
        }

        .auto-style5 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <h1 class="Title">CAMBIAR CONTRASEÑA</h1>

        <br />
        <br />



        <div style="text-align: center; font-size: large">
            <table id="tabla1" runat="server" class="Center">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Introduzca su Email:"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Email" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Tiene que ser una direccion de correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator></td>

                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="solicitar" runat="server" Text="Solicitar codigo" OnClick="solicitar_Click" />
                    </td>
                </tr>
            </table>

            <table id="tablaCod" runat="server" class="Center">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Introduzca el codigo"></asp:Label></td>
                    <td class="auto-style4">
                        <asp:TextBox ID="cod" runat="server"></asp:TextBox></td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cod" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="cod" ErrorMessage="Tiene que ser un numero" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Introduzca la nueva contraseña"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Pass" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Pass" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator></td>

                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Vuelva a introducir la nueva contraseña"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Pass2" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Pass" ControlToValidate="Pass2" ErrorMessage="Las 2 contraseñas tienen que ser iguales"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Pass2" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator></td>

                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="cambcont" runat="server" Text="Cambiar contraseña" OnClick="cambcont_Click" />
                    </td>
                </tr>
            </table>

        </div>

        <asp:Label ID="error" runat="server"></asp:Label>
        <h1>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Contraseña cambiada con exito pulse aqui para continuar</asp:HyperLink></h1>

    </form>
</body>
</html>
