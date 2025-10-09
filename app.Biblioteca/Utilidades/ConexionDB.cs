using System;

namespace app.Biblioteca.Utilidades
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
