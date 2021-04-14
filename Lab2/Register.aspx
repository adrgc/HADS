﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Lab2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

        .auto-style2 {
            width: 140px;
        }

        .auto-style3 {
            height: 26px;
            width: 140px;
        }

        .auto-style4 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <h1 class="Title">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            REGISTER</h1>
        <br />
        <br />
        <div style="text-align: center">
            <table id="register" style="margin-left: 35%" runat="server">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Email" runat="server" Style="margin-left: 0px" Width="230px"></asp:TextBox>

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Requerido" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email" ErrorMessage="Tiene que ser una direccion de correo valida" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Name" runat="server" Style="margin-left: 0px" Width="230px"></asp:TextBox>

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Name" ErrorMessage="Requerido" ValidationGroup="reg"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Apellidos"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Surname" runat="server" Style="margin-left: 0px" Width="230px"></asp:TextBox>

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Surname" ErrorMessage="Requerido" ValidationGroup="reg"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Pwd" runat="server" Style="margin-left: 0px" Width="230px" TextMode="Password"></asp:TextBox>

                        <ajaxToolkit:PasswordStrength ID="Pwd_PasswordStrength" runat="server" MinimumUpperCaseCharacters="1" PreferredPasswordLength="6" TargetControlID="Pwd" />

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Pwd" ErrorMessage="Requerido" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Pwd" ErrorMessage="Minimo 6 caracteres" ValidationExpression=".{6,}" ValidationGroup="reg"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Repetir Contraseña"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Pwd2" runat="server" Style="margin-left: 0px" Width="230px" TextMode="Password"></asp:TextBox>

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Pwd2" ErrorMessage="Requerido" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="ComparePass" runat="server" ControlToCompare="Pwd" ControlToValidate="Pwd2" ErrorMessage="Las contraseñas no coinciden" ViewStateMode="Enabled" ValidationGroup="reg"></asp:CompareValidator></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="Rol"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Style="margin-left: 0px; margin-top: 0px">
                            <asp:ListItem Selected="True" Value="Alumno">Alumno</asp:ListItem>
                            <asp:ListItem Value="Profesor">Profesor</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Registrarme" Width="98px" CssClass="auto-style4" /></td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Se ha enviado un correo de confirmacion pulse aqui para volver al inicio</asp:HyperLink></h1>
</body>
</html>
