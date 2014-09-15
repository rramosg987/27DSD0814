using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSucamec.Models;
using LogicaNegocios;
using Recursos;

namespace WebSucamec.Controllers
{
    public class LicenciaController : Controller
    {
        //
        // GET: /Licencia/

        [HttpGet]
        public ActionResult LicenciasPorTramitar()
        {
            LicenciasPorTramitarModel objModel = new LicenciasPorTramitarModel();
            LogicaTramite objLogicaTramite = new LogicaTramite();
            objModel.LicenciasPorTramitar = objLogicaTramite.LicenciasPorTramitar((int)Enumeraciones.EstadosTramite.Pendiente);

            return View(objModel);
        }

    }
}
