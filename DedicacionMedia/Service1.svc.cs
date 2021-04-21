using LogicaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DedicacionMedia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Service1()
        {
        }

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

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }


}
