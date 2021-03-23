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
            int log = ln.login(mail, pass);
            if (log == 0)
            {
                Session["email"] = mail;
                Response.Redirect("Alumno/Alumno.aspx");
            }
            else if (log == 1)
            {
                Session["email"] = mail;
                Response.Redirect("Profesor/Profesor.aspx");
            }
            else if (log == 2)
            {
                ERROR.Text = "Usuario o contraseña incorrectos.";
            }
            else if (log == 3)
            {
                ERROR.Text = "La cuenta no está verificada.";
            }


        }
    }
}