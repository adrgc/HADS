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
            String email = Request["mbr"];
            int conf = int.Parse(Request["numconf"]);

            if (LogicaNegocio.LogicaNegocio.confirm(email, conf))
            {
                Label1.Text = "¡Confirmación realizada con éxito!";
            }
            else
            {
                Label1.Text = "Algo no ha ido como se esperaba... :(";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}