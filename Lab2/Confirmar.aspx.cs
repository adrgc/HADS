using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Confirmar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
            db.conectar();
            String email = Request["mbr"];
            int conf = int.Parse(Request["numconf"]);

            if(db.confirm(email, conf))
            {
               // db.desconectar();
               // db.conectar();

               // db.updateUser(email);
                Label1.Text = "todo correcto";
            }
            else
            {
                Label1.Text = email;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}