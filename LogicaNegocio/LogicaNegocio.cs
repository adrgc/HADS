﻿using System;

namespace LogicaNegocio
{
    public class LogicaNegocio {
        private AccesoDatos.AccesoDatos db = new AccesoDatos.AccesoDatos();

        public void register(string name, string surn, string email, string pwd, string tipo){
        int num = new Random().Next();

        
        db.conectar();
        db.register(email, name, surn, pwd, num, tipo);
        db.desconectar();

        String subject = "Confirmacion de registro";
        String body = "<html><body><p> Se ha recibido su solicitud de registro para continuar haga click en el enlace que aparece justo abajo </p><a href = 'https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "' > https://localhost:44338/Confirmar.aspx?mbr=" + email + "&numconf=" + num + "</a></body ></html> ";

        Mail.Mail.send(email, subject, body);

        }

        public int login(string mail, string pass){
            int result = 1;
    
            db.conectar();
            result = db.login(mail, pass);

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

        public void sendCode(string email)
        {
          
            int codPass = new Random().Next();
            db.conectar();
            if (db.addCodPass(email,codPass))
            {
                String subject = "Cambio de contraseña";
                String body = "<html><body><p> Se ha recibido su solicitud de cambio de contraseña. El código para cambiarla es el siguiente: <h1>"+ codPass +"</h1></body ></html> ";

                Mail.Mail.send(email, subject, body);
            }

            db.desconectar();
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
    }
}
