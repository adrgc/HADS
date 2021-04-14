using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class InsertarTarea : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        private SqlConnection cnn;
        private DataSet dataSet;
        private DataTable table;
        private DataRow row;
        private SqlDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cnn = ln.getConection();
                dataSet = new DataSet();
                adapter = new SqlDataAdapter("SELECT * FROM TareasGenericas ", cnn);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "Tareas");
                table = dataSet.Tables["Tareas"];
                Session["datos"] = dataSet;
                Session["adapter"] = adapter;
            }
            else
            {
                dataSet = (DataSet)Session["datos"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            Label8.Text = "";
            table = dataSet.Tables["Tareas"];
            row = table.NewRow();
            row["Codigo"] = TextBox1.Text;
            row["Descripcion"] = TextBox2.Text;
            row["CodAsig"] = DropDownList1.SelectedValue;
            row["HEstimadas"] = int.Parse(TextBox3.Text);
            row["Explotacion"] = 1;
            row["TipoTarea"] = DropDownList2.SelectedValue;

            table.Rows.Add(row);
            try
            {
                adapter = (SqlDataAdapter)Session["adapter"];
                adapter.Update(dataSet, "Tareas");
                dataSet.AcceptChanges();
                Label8.Text = "Tarea insertada con exito";

            }
            catch
            {
                Label8.Text = "Ya existe una tarea con ese codigo";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}