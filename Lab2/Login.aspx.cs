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
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();

            if (ln.login(mail, pass) == 1)
            {
                ERROR.Text = "Usuario o contraseña incorrectos.";
            }
            else if (ln.login(mail, pass) == 1)
            {
                ERROR.Text = "La cuenta no está verificada.";
            }
        }
    }
}