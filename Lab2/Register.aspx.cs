using System;


namespace Lab2

{

    public partial class Register : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = Name.Text;
            String surn = Surname.Text;
            String email = Email.Text;
            String pwd = Pwd.Text;

            int num = new Random().Next();

            String subject = "Confirmacion de registro";
            String body = "<html><body><p> Se ha recibido su solicitud de registro para continuar haga click en el enlace que aparece justo abajo </p><a href = 'https://localhost:44338/Register.aspx?mbr=' + email + '&numconf=' + num + '' > https://localhost:44338/Register.aspx?mbr='+email+'&numconf='+num+'</a></body ></html> ";







        }
    }
}