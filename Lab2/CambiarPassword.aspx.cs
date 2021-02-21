using System;
using System.Web;

namespace Lab2
{
    public partial class CambiarPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tablaCod.Visible = false;
            HyperLink1.Visible = false;
        }

        protected void solicitar_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            string email = Email.Text;
            if (ln.sendCode(email))
            {
               
                solicitar.Enabled = false;
                Email.Enabled = false;
                tablaCod.Visible = true;
            }
            else
            {
                error.Text = "El correo introducido no existe en la base de datos";
            }
            

            
        }

        protected void cambcont_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            int codPass = int.Parse(cod.Text);
            string email = Email.Text;
            string newPass = Pass.Text;

            if(ln.changePass(email, newPass, codPass))
            {
                tabla1.Visible = false;
                tablaCod.Visible = false;
                HyperLink1.Visible = true;
            }
            else
            {
                error.Text = "algo no ha ido como se esperaba";
            }
        }
    }
}