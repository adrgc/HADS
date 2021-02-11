<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Style.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }
        .auto-style2 {
            width: 173px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
        
            <br />
            <h1 class="Title">LOGIN</h1>
           
            <br />
            <br />
        

        
         <div style="text-align:center; font-size:large ">
            <table class="Center" >
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox></td>
                   
                </tr>
                
                <tr>
                    <td class="auto-style2"><br /><br /><br /><asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Login" Width="98px" /></td>
                    <td class="auto-style1"><br /><br /><br /><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl ="Register.aspx">Registrarme</asp:HyperLink><br /> 
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="CambiarPassword.aspx">He olvidado mi contraseña</asp:HyperLink></td>
                </tr>
                
            </table> 
             </div>   
            
       
       
           
       
            

    </form>
</body>
</html>
