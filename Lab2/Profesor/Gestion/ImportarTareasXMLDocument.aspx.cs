using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Lab2
{
    public partial class ImportarTareasXMLDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (File.Exists(Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml")))
            {
                Xml1.DocumentSource = Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml");
                Xml1.TransformSource = Server.MapPath("../App_Data/VerTablaTareas" + DropDownList2.SelectedValue + ".xslt");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml")))
            {
                LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
                XmlDocument xml = new XmlDocument();
                xml.Load(Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml"));
                if (ln.insertarTareaPorXML(xml, DropDownList1.SelectedValue) == 0)
                {
                    Label4.Text = "XML importado con exito";
                }
                else
                {
                    Label4.Text = "Ha ocurrido some problem";
                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}