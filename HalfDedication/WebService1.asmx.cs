using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HalfDedication
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double GetHalfDedication(string asignasion)
        {
            ArrayList dedications = new ArrayList();
            LogicaNegocio.LogicaNegocio ln = new LogicaNegocio.LogicaNegocio();
            dedications = ln.getDedications(asignasion);
            if (dedications.Count == 0) return 0;
            double half = 0;
            foreach (int i in dedications)
            {
                half += i;
            }
            half /= dedications.Count;
            return half;
        }
    }
}
