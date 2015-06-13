using NiIdeaService.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CotizacionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CotizacionService.svc or CotizacionService.svc.cs at the Solution Explorer and start debugging.
    public class CotizacionService : ICotizacionService
    {
        private CotizacionDAO cotizacionDAO = null;
        private CotizacionDAO CotizacionDAO
        {
            get
            {
                if (cotizacionDAO == null)
                    cotizacionDAO = new CotizacionDAO();
                return cotizacionDAO;
            }
        }

        public Dominio.Cotizacion CreaCotizacion(decimal monto, string observacion, DateTime fecha, int codigo_p)
        {
            Dominio.Cotizacion cotizacionACrear = new Dominio.Cotizacion()
            {
                monto = monto,
                observacion = observacion,
                fecha = fecha,
                codigo_p = codigo_p
            };
            return CotizacionDAO.Crear(cotizacionACrear);
        }

        public Dominio.Cotizacion ObtieneCotizacion(int codigo_ct)
        {
            return CotizacionDAO.Obtener(codigo_ct);
        }


        public List<Dominio.Cotizacion> Listar()
        {
            return new List<Dominio.Cotizacion>() 
            { 
                new Dominio.Cotizacion(){ 
                    codigo_ct=1,codigo_p=1,fecha=new DateTime(2015,4,10), monto=1000,observacion=""
                }
            };
        }
    }
}
