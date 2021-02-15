using System;
using AccesoDatos;
namespace Lab2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
           string sisoy = db.conectar();
            Label2.Text = sisoy;
        }
    }
}