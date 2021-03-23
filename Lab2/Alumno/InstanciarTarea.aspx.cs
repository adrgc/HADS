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
    public partial class InstanciarTarea : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        private SqlConnection cnn;
        private DataSet dataSet;
        private DataTable table;
        private DataView view;
        private DataRow row;
        private SqlDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {

                cnn = ln.getConection();
                dataSet = new DataSet();
                adapter = new SqlDataAdapter("SELECT * FROM EstudiantesTareas ", cnn);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "Tareas");
                table = dataSet.Tables["Tareas"];
                view = new DataView(table);
                view.RowFilter = "Email ='" + Session["email"].ToString() + "'";
                GridView1.DataSource = view;
                GridView1.DataBind();
                Session["datos"] = dataSet;
                Session["adapter"] = adapter;

            }
            else
            {
                dataSet = (DataSet)Session["datos"];
                Button1.Enabled = false;
            }
            TextBox1.Text = Session["email"].ToString();
            TextBox2.Text = Request["tarea"];
            TextBox4.Text = ln.getHorasEstimadas(Request["tarea"]).ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string email = TextBox1.Text;
            string codTarea = TextBox2.Text;
            int hEstimadas = int.Parse(TextBox4.Text);
            int hReales = int.Parse(TextBox3.Text);

            table = dataSet.Tables["Tareas"];
            row = table.NewRow();
            row["Email"] = email;
            row["CodTarea"] = codTarea;
            row["HEstimadas"] = hEstimadas;
            row["HReales"] = hReales;


            try
            {
                table.Rows.Add(row);
                GridView1.DataSource = table;
                GridView1.DataBind();
                adapter = (SqlDataAdapter)Session["adapter"];
                adapter.Update(dataSet, "Tareas");
                dataSet.AcceptChanges();
                Label7.Text = "Tarea instanciada con exito";
            }
            catch
            {
                Label7.Text = "La tarea ya habia sido instanciada";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}