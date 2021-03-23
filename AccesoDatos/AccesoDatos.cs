using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Web.UI.WebControls;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        private SqlConnection cnn;
        private string cnnString = @"Server=tcp:hads21-11a.database.windows.net,1433;Initial Catalog=HADS21-11a;Persist Security Info=False;User ID=administreitor;Password=ASdf1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection getConection()
        {
            return new SqlConnection(cnnString);
        }
        public string conectar()
        {
            try
            {
                cnn = new SqlConnection(cnnString);
                cnn.Open();
            }
            catch (Exception ex)
            {
                return "ERROR";
            }

            Console.WriteLine("Connection Open  !");
            return "Connection Open  !";
        }
        public string desconectar()
        {
            cnn.Close();
            cnn.Dispose();
            Console.WriteLine("Connection dis Open  !");
            return "desconictado";
        }

        public Boolean register(string email, string nombre, string apellidos, string contraseña, int cod, string tipo)
        {

            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction = cnn.BeginTransaction();

            command.Connection = cnn;
            command.Transaction = transaction;

            command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "' ";
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return false;
            }
            dr.Close();
            try
            {
                command.CommandText =
                    "Insert into Usuarios (email, nombre, apellidos, numconfir, confirmado, tipo, pass) VALUES ('" + email + "','" + nombre + "','" + apellidos + "'," + cod + ", 0, '" + tipo + "','" + contraseña + "' )";
                command.ExecuteNonQuery();


                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                return false;
            }
        }
        public int login(string email, string pwd)
        {
            SqlCommand command = cnn.CreateCommand();

            command.Connection = cnn;
            int result = 2;
            try
            {
                command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "' AND pass ='" + pwd + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    result = 3;
                    var conf = (Boolean)dr.GetValue(4);

                    if (conf)
                    {
                        if ((string)dr.GetValue(5) == "Alumno")
                        {
                            return 0;
                        }
                        else if ((string)dr.GetValue(5) == "Profesor")
                        {
                            return 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return result;
        }
        public Boolean confirm(string email, int cod)
        {
            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction = cnn.BeginTransaction();

            command.Connection = cnn;
            command.Transaction = transaction;

            try
            {
                command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "' AND numconfir =" + cod + "";

                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    command.CommandText = "UPDATE Usuarios SET confirmado = 1 WHERE email = '" + email + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                return false;
            }
        }

        public Boolean addCodPass(string email, int codPass)
        {
            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction = cnn.BeginTransaction();

            command.Connection = cnn;
            command.Transaction = transaction;

            Boolean correcto = false;
            try
            {
                command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    command.CommandText = "UPDATE Usuarios SET codpass = " + codPass + " WHERE email = '" + email + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    correcto = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return correcto;
        }
        public Boolean changePass(string email, string newPass, int codPass)
        {
            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction = cnn.BeginTransaction();

            command.Connection = cnn;
            command.Transaction = transaction;

            Boolean correcto = false;
            try
            {
                command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "' AND codpass='" + codPass + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    command.CommandText = "UPDATE Usuarios SET pass = '" + newPass + "' WHERE email = '" + email + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    correcto = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            return correcto;
        }

        public DataTable getTareasAlumno(string cod, string email)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Codigo, Descripcion, HEstimadas, TipoTarea FROM TareasGenericas WHERE  Explotacion = 1 AND CodAsig = '" + cod + "' AND Codigo NOT IN (Select CodTarea FROM EstudiantesTareas WHERE Email ='" + email + "' )  ", cnnString);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public int getHorasEstimadas(string codigo)
        {
            SqlCommand command = cnn.CreateCommand();


            command.Connection = cnn;

            try
            {
                command.CommandText = "SELECT HEstimadas FROM TareasGenericas WHERE Codigo ='" + codigo + "'";
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();

                return (int)dr.GetValue(0);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");

            }

            return 99999999;
        }

        public int insertarTareaPorXML(XmlDocument xml, string codAsign)
        {
            DataSet dataSet = new DataSet();
            DataTable table;
            DataRow row;
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM TareasGenericas where 'vadillo'='top tier profe' ", cnnString);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "Tareas");
                table = dataSet.Tables["Tareas"];

                XmlNodeList listaTareas = xml.GetElementsByTagName("tareas");
                XmlNodeList tareas = ((XmlElement)listaTareas[0]).GetElementsByTagName("tarea");

                foreach (XmlElement tarea in tareas)
                {
                    row = table.NewRow();
                    row["Codigo"] = tarea.GetAttribute("codigo");
                    row["CodAsig"] = codAsign;
                    row["Descripcion"] = tarea.GetElementsByTagName("descripcion")[0].InnerText;
                    row["HEstimadas"] = Int32.Parse(tarea.GetElementsByTagName("hestimadas")[0].InnerText);
                    row["Explotacion"] = Boolean.Parse(tarea.GetElementsByTagName("explotacion")[0].InnerText);
                    row["TipoTarea"] = tarea.GetElementsByTagName("tipotarea")[0].InnerText;
                    table.Rows.Add(row);

                }
                adapter.Update(dataSet, "Tareas");
                dataSet.AcceptChanges();

            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }

        public int insertarTareaPorXMLOpcional(DataSet ds, string codAsign)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable table;
                SqlDataAdapter adapter;

                adapter = new SqlDataAdapter("SELECT * FROM TareasGenericas where 'vadillo'='top tier profe' ", cnnString);
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "Tareas");
                table = dataSet.Tables["Tareas"];

                DataTable dt = ds.Tables[0];

                dt.Columns.Add("CodAsig");

                foreach (DataRow row in dt.Rows)
                {
                    row["CodAsig"] = codAsign;
                }

                ds.Merge(dt);

                adapter.Update(ds, "tarea");
                ds.AcceptChanges();

            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }
        public DataView getTareasAsignatura(DataSet dt, string codAsig)
        {
            DataView view = new DataView(dt.Tables[0]);
            view.RowFilter = "CodAsig ='" + codAsig + "'";
            return view;
        }

        public DataSet getTareasAsignaturaXML(string xml, string codAsig)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
            return ds;
        }

        public object[] actualizarDataset(string email)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TareasGenericas WHERE CodAsig IN (SELECT GruposClase.codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (ProfesoresGrupo.email = '" + email + "'))", this.getConection());
            adapter.Fill(dataSet);
            return new object[2] { dataSet, adapter };
        }
    }
}
