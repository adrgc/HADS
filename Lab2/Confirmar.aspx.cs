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
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            String email = Request["mbr"];
            int conf = int.Parse(Request["numconf"]);

            if (ln.confirm(email, conf))
            {
                confirmar.Text = "¡Confirmación realizada con éxito! pulse aqui para continuar";
            }
            else
            {
                error.Text = "Algo no ha ido como se esperaba... :(";
            }
        }

        
    }
}