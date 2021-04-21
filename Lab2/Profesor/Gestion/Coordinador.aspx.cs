using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2.Profesor.Gestion
{
    public partial class Coordinador : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                string codAsig = DropDownList1.SelectedValue;
                HR.Text = ln.getHalfDedication(codAsig).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}