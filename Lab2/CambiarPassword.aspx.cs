using System;

namespace Lab2
{
    public partial class CambiarPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tablaCod.Visible = false;
        }

        protected void solicitar_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            string email = Email.Text;

            solicitar.Enabled = false;
            Email.Enabled = false;
            tablaCod.Visible = true;
            

            ln.sendCode(email);
        }

        protected void cambcont_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            int codPass = int.Parse(cod.Text);
            string email = Email.Text;
            string newPass = Pass.Text;

            if(ln.changePass(email, newPass, codPass))
            {
                //Text: cambio realizado correctamente
            }
            else
            {
                //ERROR
            }
        }
    }
}