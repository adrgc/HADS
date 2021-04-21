using LogicaDelNegocio.ContraseñaHard;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

using System.Xml.Linq;

namespace LogicaNegocio
{
    public class LogicaNegocio
    {
        private AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();


        public int register(string name, string surn, string email, string pwd, string tipo)
        {
            int num = new Random().Next();
            string encPwd = encriptar(pwd);

            if (emailMatriculado(email) == 1)
            {
                return 2;
            }

            db.conectar();



            if (!db.register(email, name, surn, encPwd, num, tipo))
            {
                db.desconectar();
                return 1;
            }
            db.desconectar();

            String subject = "Confirmacion de registro";
            String body = "<html><body><p> Se ha recibido su solicitud de registro para continuar haga click en el enlace que aparece justo abajo </p><a href = 'https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "' > https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "</a></body ></html> ";

            Mail.Mail.send(email, subject, body);
            return 0;

        }
        public int comprobarContraseña(string pwd)
        {
            //Servicio web Creado por G10 
            Boolean result;
            Service1Client client = new Service1Client();
            result = client.Comprobar(pwd, "tenia_que_haber_satelites");

            client.Close();
            if (result) { return 0; } else { return 1; }

        }
        public int emailMatriculado(string email)
        {
            var matriculado = new LogicaDelNegocio.matriculas.Matriculas();
            if (matriculado.comprobar(email) == "SI")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int login(string mail, string pass)
        {
            int result = 2;

            db.conectar();
            string encPwd = encriptar(pass);
            result = db.login(mail, encPwd);

            db.desconectar();
            return result;
        }

        public Boolean confirm(string email, int conf)
        {
            Boolean correcto = false;

            db.conectar();
            if (db.confirm(email, conf))
            {
                correcto = true;
            }
            db.desconectar();
            return correcto;
        }

        public Boolean sendCode(string email)
        {

            int codPass = new Random().Next();
            db.conectar();
            if (db.addCodPass(email, codPass))
            {
                String subject = "Cambio de contraseña";
                String body = "<html><body><p> Se ha recibido su solicitud de cambio de contraseña. El código para cambiarla es el siguiente: <h1>" + codPass + "</h1></body ></html> ";

                Mail.Mail.send(email, subject, body);
                db.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }


        }
        public Boolean changePass(string email, string newPass, int codPass)
        {
            Boolean correcto = false;
            db.conectar();

            if (db.changePass(email, newPass, codPass))
            {
                correcto = true;
            }
            db.desconectar();
            return correcto;
        }

        public DataTable getTareasAlumno(string cod, string email)
        {
            db.conectar();
            DataTable result = db.getTareasAlumno(cod, email);
            db.desconectar();

            return result;
        }

        public int getHorasEstimadas(string codigo)
        {
            db.conectar();
            int result = db.getHorasEstimadas(codigo);
            db.desconectar();

            return result;
        }


        public SqlConnection getConection()
        {
            db.conectar();
            SqlConnection ret = db.getConection();
            db.desconectar();
            return ret;
        }
        public int insertarTareaPorXML(XmlDocument xml, string codAsign)
        {
            db.conectar();
            int ret = db.insertarTareaPorXML(xml, codAsign);
            db.desconectar();
            return ret;
        }
        public int insertarTareaPorXMLOpcional(DataSet ds, string codAsign)
        {
            db.conectar();
            int ret = db.insertarTareaPorXMLOpcional(ds, codAsign);
            db.desconectar();
            return ret;
        }
        public object[] actualizarDataset(string email)
        {
            db.conectar();
            object[] ret = db.actualizarDataset(email);
            db.desconectar();
            return ret;
        }

        public DataView getTareasAsignatura(DataSet dt, string codAsig)
        {
            db.conectar();
            DataView ret = db.getTareasAsignatura(dt, codAsig);
            db.desconectar();
            return ret;
        }
        public DataSet getTareasAsignaturaXML(string xml, string codAsig)
        {
            db.conectar();
            DataSet ret = db.getTareasAsignaturaXML(xml, codAsig);
            db.desconectar();
            return ret;
        }
        public int exportXml(DataView dv, string asig, string file)
        {

            //string file = @"C:\Users\Adrian\source\repos\Lab2\Lab2\App_Data\" + asig + ".xml";
            int count = 1;
            try
            {   /*   
                 *  CREA UN ARCHIVO PARA CADA EXPORTACIÓN. Ej: SEG(1).xml 
                 *  Por tu comodidad finalmente no ha sido insertado
                while (File.Exists(file))
                {
                    file = @"C:\Users\Adrian\source\repos\Lab2\Lab2\App_Data\" + asig + "(" + count + ").xml";
                    count++;
                }
                */
                XmlWriter writer = new XmlTextWriter(file, Encoding.Unicode);

                DataTable dt = dv.ToTable("tarea");
                DataSet ds = new DataSet("tareas");
                dt.Columns.Remove("CodAsig");

                foreach (DataColumn dc in dt.Columns)
                {
                    dc.ColumnName = dc.ColumnName.ToLower();
                }

                dt.Columns["codigo"].ColumnMapping = MappingType.Attribute;
                ds.Tables.Add(dt);
                ds.WriteXml(writer);
                writer.Close();

                // Añadir atributo a la raiz
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(file);
                xdoc.DocumentElement.SetAttribute("xmlns:has", "http://ji.ehu.es/has");
                xdoc.Save(file);
            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }
        public int exportJson(DataView dv, string asig, string file)
        {
            try
            {
                DataTable dt = dv.ToTable("tarea");
                dt.Columns.Remove("CodAsig");

                foreach (DataColumn dc in dt.Columns)
                {
                    dc.ColumnName = dc.ColumnName.ToLower();
                }

                string json = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(file, json);

                return 0;
            }
            catch (Exception e)
            {
                return 1;
            }

        }
        public ArrayList getDedications(string codAsig)
        {
            db.conectar();
            ArrayList ret = db.getDedications(codAsig);
            db.desconectar();
            return ret;
        }
        private static string encriptar(string pwd)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificacion = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificacion.GetBytes(pwd));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public double getHalfDedication(string codAsig)
        {
            var dedicacion = new LogicaDelNegocio.halfdedication.WebService1();
            return dedicacion.GetHalfDedication(codAsig);

        }


    }
}
