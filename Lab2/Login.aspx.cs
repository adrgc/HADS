using System;
using AccesoDatos;
using System.Web.Security;
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
                System.Web.Security.FormsAuthentication.SetAuthCookie("alumno", true);
                Session["email"] = mail;
                Response.Redirect("Alumno/Alumno.aspx");
            }
            else if (log == 1)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie("profesor", true);
                Session["email"] = mail;
                if (mail == "vadillo@ehu.es") System.Web.Security.FormsAuthentication.SetAuthCookie("vadillo", true);

                Response.Redirect("Profesor/Profesor.aspx");
            }
            else if (log == 2)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie("admin", true);
                Session["email"] = mail;
                Response.Redirect("Admin/GestionarUsuarios.aspx");
            }
            else if (log == 3)
            {
                ERROR.Text = "Usuario o contraseña incorrectos.";
            }
            else if (log == 4)
            {
                ERROR.Text = "La cuenta no está verificada.";
            }


        }
    }
}