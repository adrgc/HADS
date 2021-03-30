using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncriptacionMD5
{
    public class Encriptacion
    {
        public static string encriptar(string pwd)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificacion = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificacion.GetBytes(pwd));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
