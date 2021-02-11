<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarPassword.aspx.cs" Inherits="Lab2.CambiarPassword" %>

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
            <h1 class="Title">CAMBIAR CONTRASEÑA</h1>
           
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
           
            <br />
            <br />
        

        
         <div style="text-align:center; font-size:large ">
            <table id="tabla1" runat="server" class="Center" >
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label2" runat="server" Text="Introduzca su Email:"></asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="Email" runat="server" ></asp:TextBox></td>
                   
                </tr>
                <tr>
                <td colspan="2"> 
                         <asp:Button ID="solicitar" runat="server" Text="Solicitar codigo" OnClick="solicitar_Click" />
                     </td>
                    </tr>
            </table> 

             <table class="Center" style="display:none" >
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label1" runat="server" Text="Introduzca el codigo"></asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="cod" runat="server" ></asp:TextBox></td>
                   
                </tr>
                 <tr>
                    <td class="auto-style2"><asp:Label ID="Label3" runat="server" Text="Introduzca la nueva contraseña"></asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="Pass" runat="server" ></asp:TextBox></td>
                   
                </tr>
                 <tr>
                    <td class="auto-style2"><asp:Label ID="Label4" runat="server" Text="Vuelva a introducir la nueva contraseña"></asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="Pass2" runat="server" ></asp:TextBox></td>
                   
                </tr>

                 <tr>
                     <td colspan="2"> 
                         <asp:Button ID="cambcont" runat="server" Text="Cambiar contraseña" />
                     </td>
                 </tr>
            </table> 

             </div>   
            
       
       
           
       
            

    </form>
</body>
</html>
