using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2.Profesor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        private DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                string xml = Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml");

                ds = ln.getTareasAsignaturaXML(xml, DropDownList1.SelectedValue);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ln.insertarTareaPorXMLOpcional(ds, DropDownList1.SelectedValue) == 0)
            {
                Label4.Text = "XML importado con exito";
            }
            else
            {
                Label4.Text = "Algun problema has occurred";
            }
        }
    }
}

