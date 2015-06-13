using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NiIdeaService.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int codigo_c { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string doc_ide { get; set; }

        
    }
}