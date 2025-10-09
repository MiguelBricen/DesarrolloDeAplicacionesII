using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app._Nombre_.Utilidades
{
    public static class conexionDB
    {

        public static string ObtenerConexion()
        {
            var conexion = Administrarconexion.Cargar();
            if (string.IsNullOrWhiteSpace(conexion?.servidor) || string.IsNullOrWhiteSpace
                (conexion?.baseDatos))
                throw new InvalidOperationException("La conexión no esta configurada.");
            return conexion.cadenaConexion;
        }
    }
}
