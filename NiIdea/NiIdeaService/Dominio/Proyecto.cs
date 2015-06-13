using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NiIdeaService.Dominio
{
    [DataContract]
    public class Proyecto
    {
        [DataMember]
        public int codigo_p { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public DateTime fecha_ini { get; set; }
        [DataMember]
        public DateTime fecha_fin { get; set; }
        [DataMember]
        public string responsable { get; set; }
        [DataMember]
        public string observacion { get; set; }
        [DataMember]
        public int codigo_c { get; set; }
        [DataMember]
        public int estado { get; set; }


    }
}