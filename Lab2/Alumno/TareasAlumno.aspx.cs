using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Lab2
{
    public partial class TareasAlumno : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        private SqlConnection cnn;
        private DataSet dataSetDDList;
        private DataSet dataSetDgrid;
        private DataTable dataTableDDList;
        private DataTable dataTableDgrid;
        private SqlDataAdapter adapterDDList;
        private SqlDataAdapter adapterDgrid;
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            cnn = ln.getConection();
            if (!this.IsPostBack)
            {

                dataSetDDList = new DataSet();
                adapterDDList = new SqlDataAdapter("SELECT codigoasig FROM EstudiantesGrupo INNER JOIN GruposClase ON EstudiantesGrupo.Grupo = GruposClase.codigo WHERE EstudiantesGrupo.Email ='" + Session["email"].ToString() + "'", cnn);
                adapterDDList.Fill(dataSetDDList, "Asignaturas");
                dataTableDDList = dataSetDDList.Tables["Asignaturas"];
                asignaturasList.DataSource = dataSetDDList.Tables[0];
                asignaturasList.DataTextField = "codigoasig";
                asignaturasList.DataValueField = "codigoasig";
                asignaturasList.DataBind();

            }

            Label7.Text = "";
            dataSetDgrid = new DataSet();
            adapterDgrid = new SqlDataAdapter("SELECT Codigo, Descripcion, HEstimadas, TipoTarea FROM TareasGenericas WHERE  Explotacion = 1 AND CodAsig = '" + asignaturasList.SelectedValue + "' AND Codigo NOT IN (Select CodTarea FROM EstudiantesTareas WHERE Email ='" + Session["email"].ToString() + "' )  ", cnn);
            adapterDgrid.Fill(dataSetDgrid, "Tareas");
            dataTableDgrid = dataSetDgrid.Tables["Tareas"];

            table.DataSource = dataTableDgrid;
            table.DataBind();
            if (dataTableDgrid.Rows.Count == 0)
            {
                Label7.Text = "NO HAY TAREAS";
            }

        }

        protected void table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void instanciarBoton_Click(object sender, EventArgs e)
        {
            string tarea = Convert.ToString((sender as Button).CommandArgument);
            Response.Redirect("InstanciarTarea.aspx?tarea=" + tarea);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx");
        }
    }
}