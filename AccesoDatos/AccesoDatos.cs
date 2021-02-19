using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public   class AccesoDatos 
    {
        private SqlConnection cnn;
        public string  conectar()
        {
            string connetionString = @"Server=tcp:hads21-11a.database.windows.net,1433;Initial Catalog=HADS21-11a;Persist Security Info=False;User ID=administreitor;Password=ASdf1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string connetionString = @"Server=tcp:hads21-11.database.windows.net,1433;Initial Catalog=HADS21-11;Persist Security Info=False;User ID=jontellechea@hotmail.com@hads21-11;Password=ASD123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            try
            {
            cnn = new SqlConnection(connetionString);
             cnn.Open();
            }catch(Exception ex)
            {
                return "ERROR";
            }
            
            Console.WriteLine("Connection Open  !");
            return "Connection Open  !";
        }
        public string desconectar()
        {
            cnn.Close();
            Console.WriteLine("Connection dis Open  !");
            return "desconictado";
        }

        public void register(string email, string nombre, string apellidos, string contraseña, int cod, string tipo)
        {

            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction = cnn.BeginTransaction();

            command.Connection = cnn;
            command.Transaction = transaction;

            try
            {
                command.CommandText =
                    "Insert into Usuarios (email, nombre, apellidos, numconfir, confirmado, tipo, pass) VALUES ('"+email+ "','" + nombre + "','" + apellidos + "'," + cod + ", 0, '" + tipo + "','" + contraseña + "' )";
                command.ExecuteNonQuery();


                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");

            }
        }
        public Boolean login(string email, string pwd)
        {
            SqlCommand command = cnn.CreateCommand();

            command.Connection = cnn;

            try
            {
                command.CommandText = " SELECT * FROM Usuarios where email ='" + email + "' AND pass ='" + pwd + "'";
                SqlDataReader dr = command.ExecuteReader();
                return dr.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                return false;
            }
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
                
                if (dr.Read()){
                    dr.Close();
                    command.CommandText = "UPDATE Usuarios SET confirmado = 1 WHERE email = '" + email + "'";
                    command.ExecuteNonQuery();
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

      
    }
}
