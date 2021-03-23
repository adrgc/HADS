﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Lab2
{
    public partial class ExportarTareas : System.Web.UI.Page
    {
        private LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
        private DataView dv;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                object[] datasetAndAdapter = ln.actualizarDataset((string)Session["email"]);
                Session["DatasetTareasGenericas"] = datasetAndAdapter[0];
                Session["AdapterTareasGenericas"] = datasetAndAdapter[1];

            }
            else
            {
                dv = ln.getTareasAsignatura((DataSet)Session["DatasetTareasGenericas"], DropDownList1.SelectedValue);
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ln.exportXml(dv, DropDownList1.SelectedValue, Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".xml")) == 0)
            {
                Label4.Text = "Archivo exportado con exito";
            }
            else
            {
                Label4.Text = "Some problem ha ocurrido";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ln.exportJson(dv, DropDownList1.SelectedValue, Server.MapPath("../App_Data/" + DropDownList1.SelectedValue + ".json")) == 0)
            {
                Label4.Text = "Archivo exportado con exito";
            }
            else
            {
                Label4.Text = "Some problem ha ocurrido";
            }
        }
    }
}