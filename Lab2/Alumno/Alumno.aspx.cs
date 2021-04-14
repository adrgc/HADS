using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> usuarios = (List<String>)Application["usuarios"];
            List<String> profesores = (List<String>)Application["profesores"];
            ListBox1.DataSource = usuarios;
            ListBox1.DataBind();

            ListBox2.DataSource = profesores;
            ListBox2.DataBind();

            alumnos.Text = usuarios.Count.ToString();
            profes.Text = profesores.Count.ToString();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}