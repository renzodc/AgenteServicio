using NiIdeaService.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICotizacionService" in both code and config file together.
    [ServiceContract]
    public interface ICotizacionService{

        [OperationContract]
        List<Cotizacion> Listar();

        [OperationContract]
        Cotizacion CreaCotizacion(decimal monto, string observacion, DateTime fecha, int codigo_p);

        [OperationContract]
        Cotizacion ObtieneCotizacion(int codigo_ct);
    }
}
