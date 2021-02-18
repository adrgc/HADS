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
            AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
            db.conectar();
            if(db.login(mail, pass))
            {
                //mandar a inicio
                ERROR.Text = "tuuu pensabas que yoooo me iba a moriiiir";
            }
            else
            {
                ERROR.Text = "Alguno de los campos no coincide";
            }
            db.desconectar();
        }
    }
}