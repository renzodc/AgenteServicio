using NiIdeaService.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProyectoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProyectoService.svc o ProyectoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProyectoService : IProyectoService
    {
        private ProyectoDAO proyectoDAO = null;
        private ProyectoDAO ProyectoDAO
        {
            get
            {
                if (proyectoDAO == null)
                    proyectoDAO = new ProyectoDAO();
                return proyectoDAO;
            }
        }

        private ClienteDAO clienteDAO = null;
        private ClienteDAO ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDAO();
                return clienteDAO;
            }
        }
        
        public Dominio.Proyecto CreaProyecto(string nombre, DateTime fecha_ini, DateTime fecha_fin, string responsable, string observacion, int codigo_c, int estado)
        {
            //Dominio.Cliente clienteExistente = ClienteDAO.Obtener(cliente.codigo_c  ); 
            
            /* Aregar regla de negocip para registro de proyecto.
             * 
             */
            //if (clienteExistente = null )
                // mensaje de alerta
            //Else
            //{
                Dominio.Proyecto proyectoACrear = new Dominio.Proyecto()
                {

                    nombre = nombre,
                    fecha_ini= fecha_ini,
                    fecha_fin=fecha_fin,
                    responsable=responsable,
                    observacion=observacion,
                    codigo_c = codigo_c,
                    estado = estado
                };
                return ProyectoDAO.Crear(proyectoACrear);  
            //}
        }

        public Dominio.Proyecto ObtieneProyecto(int codigo_p)
        {
            return ProyectoDAO.Obtener(codigo_p);  
        }

        public Dominio.Proyecto ModificaProyecto(int codigo_p, string nombre, DateTime fecha_ini, DateTime fecha_fin, string responsable, string observacion, int codigo_c, int estado)
        {
            ///Dominio.Cliente clienteExistente = ClienteDAO.Obtener(codigo_c); 
            Dominio.Proyecto proyectoAModificar = new Dominio.Proyecto()
            {
                codigo_p = codigo_p,
                nombre = nombre,
                fecha_ini = fecha_ini,
                fecha_fin = fecha_fin,
                responsable=responsable,
                observacion = observacion,
                codigo_c = codigo_c,
                estado =estado
            };
            return ProyectoDAO.Modificar(proyectoAModificar);  
        }

        public void EliminarProyecto(int codigo_p)
        {
            Dominio.Proyecto proyectoExistente = ProyectoDAO.Obtener(codigo_p);
            ProyectoDAO.Eliminar(proyectoExistente);  
        }

        public List<Dominio.Proyecto> ListarProyecto()
        {
            return ProyectoDAO.ListarTodos().ToList();   
        }
    }
}
