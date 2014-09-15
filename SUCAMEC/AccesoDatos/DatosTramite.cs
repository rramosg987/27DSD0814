using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class DatosTramite:Conexion
    {
        public List<EntidadTramite> LicenciasPorTramitar(int intEstado)
        {
            string strCadenaConexion = DevuelveConexion();
            SqlConnection con = new SqlConnection(strCadenaConexion);
            SqlCommand com = new SqlCommand("LicenciasPorTramitar", con);
            com.Parameters.Add(new SqlParameter("Estado", intEstado));
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            SqlDataReader drLicenciasPorTramitar = com.ExecuteReader();
            List<EntidadTramite> LicenciasPorTramitar = new List<EntidadTramite>();

            while (drLicenciasPorTramitar.Read())
            {
                LicenciasPorTramitar.Add(CargarLicencias(drLicenciasPorTramitar));
            }

            drLicenciasPorTramitar.Close();
            con.Close();
            return LicenciasPorTramitar;
        }

        private EntidadTramite CargarLicencias(SqlDataReader drLicencia)
        {
            EntidadTramite Licencia = new EntidadTramite();
            Licencia.CodTramite = int.Parse(drLicencia["Cod_Tramite"].ToString());
            Licencia.CodCiudadano = int.Parse(drLicencia["Cod_Ciudadano"].ToString());
            Licencia.NombreCiudadano = drLicencia["Nombres"].ToString();
            Licencia.ApellidoPaternoCiudadano = drLicencia["Ap_Paterno"].ToString();
            Licencia.ApellidoMaternoCiudadano = drLicencia["Ap_Materno"].ToString();
            Licencia.DNICiudadano = drLicencia["DNI"].ToString();

            return Licencia;

        }
    }
}
