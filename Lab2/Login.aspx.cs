using System;
using AccesoDatos;
using System.Web.Security;
using System.Collections.Generic;

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
                Session["tipousu"] = 0;

                List<String> usuarios = (List<String>)Application.Get("usuarios");
                usuarios.Add(mail);

                Response.Redirect("Alumno/Alumno.aspx");
            }
            else if (log == 1)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie("profesor", true);
                Session["email"] = mail;
                Session["tipousu"] = 1;
                if (mail == "vadillo@ehu.es") System.Web.Security.FormsAuthentication.SetAuthCookie("vadillo", true);

                List<String> profesores = (List<String>)Application.Get("profesores");
                profesores.Add(mail);

                Response.Redirect("Profesor/Profesor.aspx");
            }
            else if (log == 2)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie("admin", true);
                Session["email"] = mail;
                Session["tipousu"] = 2;

                List<String> profesores = (List<String>)Application.Get("profesores");
                profesores.Add(mail);

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