using System;

namespace LogicaNegocio
{
    public class LogicaNegocio { 

        public static void register(string name, string surn, string email, string pwd, string tipo){
        int num = new Random().Next();

        AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
        db.conectar();
        db.register(email, name, surn, pwd, num, tipo);
        db.desconectar();

        String subject = "Confirmacion de registro";
        String body = "<html><body><p> Se ha recibido su solicitud de registro para continuar haga click en el enlace que aparece justo abajo </p><a href = 'https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "' > https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "</a></body ></html> ";

        Mail.Mail.send(email, subject, body);

        }

        public static Boolean login(string mail, string pass){
            Boolean correcto = false;
            AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
            db.conectar();
            if (db.login(mail, pass))
            {
                correcto = true;
            }
            db.desconectar();
            return correcto;
        }

        public static Boolean confirm(string email, int conf)
        {
            Boolean correcto = false;
            AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();
            db.conectar();
            if (db.confirm(email, conf))
            {
                correcto = true;
            }
            db.desconectar();
            return correcto;
        }
    
    }
}
