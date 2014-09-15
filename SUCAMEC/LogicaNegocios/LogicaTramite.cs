using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class LogicaTramite
    {
        public List<EntidadTramite> LicenciasPorTramitar(int intEstado)
        {
            DatosTramite objDatosTramite = new DatosTramite();
            List<EntidadTramite> objListaPorTramitar = new List<EntidadTramite>();

            objListaPorTramitar = objDatosTramite.LicenciasPorTramitar(intEstado);
            return objListaPorTramitar;
        }
    }
}
