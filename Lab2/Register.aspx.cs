using System;


namespace Lab2

{

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            String name = Name.Text;
            String surn = Surname.Text;
            String email = Email.Text;
            String pwd = Pwd.Text;
            String tipo = RadioButtonList1.SelectedValue;

            if (ln.register(name, surn, email, pwd, tipo))
            {
                Label1.Text = "";
                register.Visible = false;
                HyperLink1.Visible = true;

            }
            else
            {
                Label1.Text = "ya existe un usuario con ese email";
            }
        }

        
    }
}