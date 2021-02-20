using System;


namespace Lab2

{

    public partial class Register : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            String name = Name.Text;
            String surn = Surname.Text;
            String email = Email.Text;
            String pwd = Pwd.Text;
            String tipo = RadioButtonList1.SelectedValue;

            ln.register(name,surn,email,pwd,tipo);
        }
    }
}