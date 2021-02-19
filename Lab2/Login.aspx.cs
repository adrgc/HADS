using System;
using AccesoDatos;
namespace Lab2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string mail = email.Text;
            string pass = pwd.Text;

            if (!LogicaNegocio.LogicaNegocio.login(mail, pass))
            {
                ERROR.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}