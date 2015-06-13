using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NiIdeaService.Dominio
{
    [DataContract]
    public class Cotizacion
    {
        [DataMember]
        public int codigo_ct { get; set; }

        [DataMember]
        public decimal monto { get;set ;}

        [DataMember]
        public string observacion { get; set; }

        [DataMember]
        public DateTime fecha { get; set; }

        [DataMember]
        public int codigo_p { get; set; }
    }
}