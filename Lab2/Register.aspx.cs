using System;


namespace Lab2

{

    public partial class Register : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Visible = false;
            string Password = Pwd.Text;
            Pwd.Attributes.Add("value", Password);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            String name = Name.Text;
            String surn = Surname.Text;
            String email = Email.Text;
            String pwd = Pwd.Text;
            String tipo = RadioButtonList1.SelectedValue;
            switch (ln.register(name, surn, email, pwd, tipo))
            {
                case 0:
                    Label1.Text = "";
                    register.Visible = false;
                    HyperLink1.Visible = true;
                    break;
                case 1:
                    Label1.Text = "Ya existe un usuario con ese email";
                    break;
                case 2:
                    Label1.Text = "El usuario no está matriculado";
                    break;
                default:
                    Label1.Text = "Ha ocurrido un error";
                    break;
            }

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }

        protected void Email_TextChanged(object sender, EventArgs e)
        {
            if (ln.emailMatriculado(Email.Text) == 0)
            {
                Label1.Text = "El email está matriculado";
                Button1.Enabled = true;
            }
            else
            {
                Label1.Text = "El email no está matriculado";
                Button1.Enabled = false;
            }
        }
        protected void Pwd_TextChanged(object sender, EventArgs e)
        {

            if (ln.comprobarContraseña(Pwd.Text) == 0)
            {
                Label8.Text = "La contraseña no es segura";
            }
            else
            {
                Label8.Text = "La contraseña es segura";
            }
        }
    }
}