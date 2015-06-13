using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiIdeaService.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=(local);Initial Catalog=BD_PROYECTO;Integrated Security=SSPI;";
        }

        /*public static string ObtenerCadenaComercial()
        {
            return "Data Source=(local);Initial Catalog=BD_COMERCIAL;Integrated Security=SSPI;";
        }*/
    }
}