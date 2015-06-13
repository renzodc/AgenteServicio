using NiIdeaService.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProyectoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProyectoService
    {
        [OperationContract]
        Proyecto CreaProyecto(string nombre, DateTime fecha_ini, DateTime fecha_fin, string responsable, string observacion, int codigo_c, int estado);
        [OperationContract]
        Proyecto ObtieneProyecto(int codigo_p);
        [OperationContract]
        Proyecto ModificaProyecto(int codigo_p, string nombre, DateTime fecha_ini, DateTime fecha_fin, string responsable, string observacion, int codigo_c, int estado);
        [OperationContract]
        void EliminarProyecto(int codigo_p);
        [OperationContract]
        List<Proyecto> ListarProyecto(); 
    }
}
