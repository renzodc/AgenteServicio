using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgenteServicios;
using ClienteWebNildea.Models;
namespace ClienteWebNildea.Controllers
{
    public class CotizacionController : Controller
    {
        //
        // GET: /Cotizacion/

        public ActionResult Indice()
        {
            var agente = new AgenteCotizacion();
            var cotizacionDom = agente.Listar();
            var listaVM = new List<CotizacionVM>();
            cotizacionDom.ToList().ForEach((l) =>
                listaVM.Add(new CotizacionVM()
                {
                    codigo_ct = l.codigo_ct,
                    fecha = l.fecha,
                    monto = l.monto,
                    observacion = l.observacion,
                    codigo_proy=l.codigo_p 
                })
                );
            agente.Cerrar();
            return View(listaVM);
        }

        public ActionResult Agregar() 
        {
            var entidad = new CotizacionVM();
            entidad.Proyectos = new List<ProyectoVM>() 
            { 
                new ProyectoVM(){ codigo_p=1,nombre="Proyecto 01"},
                new ProyectoVM(){ codigo_p=2,nombre="Proyecto 02"}
            };
            return View(entidad);
        }

        [HttpPost]
        public ActionResult Agregar(CotizacionVM cotizacion)
        {
            var agente = new AgenteCotizacion();
            var cotizacionDom = agente.CreaCotizacion(cotizacion.monto,cotizacion.observacion
                ,cotizacion.fecha,cotizacion.codigo_proy);
           //Guardar Datos
            return RedirectToAction("Indice");
        }
    }
}
