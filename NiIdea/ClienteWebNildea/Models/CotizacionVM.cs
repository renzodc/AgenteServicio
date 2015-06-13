using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ClienteWebNildea.Models
{
    public class CotizacionVM
    {
        //[Display("Codigo")]
        public int codigo_ct { get; set; }

        //[Display("Monto")]
        public decimal monto { get; set; }

        //[DisplayColumn("Observacion")]
        public string observacion { get; set; }

        //[DisplayColumn("Fecha")]
        public DateTime fecha { get; set; }

        
        public int codigo_proy { get; set; }

        public List<ProyectoVM> Proyectos { get; set; }
        
    }
}