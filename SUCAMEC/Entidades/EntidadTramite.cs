using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EntidadTramite
    {
        public int CodTramite { get; set; }
        public int CodCiudadano { get; set; }
        public string NombreCiudadano { get; set; }
        public string ApellidoPaternoCiudadano { get; set; }
        public string ApellidoMaternoCiudadano { get; set; }
        public string DNICiudadano { get; set; }
    }
}
