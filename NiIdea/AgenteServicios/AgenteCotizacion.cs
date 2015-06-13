using NiIdeaService;
using NiIdeaService.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AgenteServicios
{
    public class AgenteCotizacion:ICotizacionService 
    {
        public ICotizacionService p { get; set; }
        public ChannelFactory<ICotizacionService> canal { get; set; }

        public AgenteCotizacion()
        {
            canal = new ChannelFactory<ICotizacionService>("Edp1");
            p = canal.CreateChannel();
             
        }        
        public void Cerrar() {
            if (canal.State == CommunicationState.Opened) canal.Close();
        }
        private void Abrir() {
            if (canal.State == CommunicationState.Closed) canal.Open();
        }




        public List<Cotizacion> Listar()
        {
            Abrir();
            return p.Listar();
        }

        public Cotizacion CreaCotizacion(decimal monto, string observacion, DateTime fecha, int codigo_p)
        {
            Abrir();
            return p.CreaCotizacion(monto, observacion, fecha, codigo_p);
        }

        public Cotizacion ObtieneCotizacion(int codigo_ct)
        {
            throw new NotImplementedException();
        }
    }
}
