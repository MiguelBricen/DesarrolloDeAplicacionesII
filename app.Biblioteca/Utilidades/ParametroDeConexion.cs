using System;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace app.Biblioteca.Utilidades
{
    [DataContract]
    public class ParametrosDeConexion
    {
        [DataMember(Order = 0)]
        public string servidor { get; set; }

        [DataMember(Order = 1)]
        public string baseDatos { get; set; }

        public string cadenaConexion =>
            $"Data Source={servidor}; Initial Catalog={baseDatos}; Integrated Security=True; Encrypt=False";

    }

    public static class Administrarconexion
    {
        private static readonly string carpeta =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "app.Biblioteca");

        private static readonly string archivo = Path.Combine(carpeta, "conexion.json");

        public static void Guardar(ParametrosDeConexion parametros)
        {
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            var serializer = new DataContractJsonSerializer(typeof(ParametrosDeConexion));
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, parametros);
                File.WriteAllText(archivo, Encoding.UTF8.GetString(ms.ToArray()), Encoding.UTF8);
            }
        }

        public static ParametrosDeConexion Cargar()
        {
            try
            {
                if (!File.Exists(archivo))
                    return new ParametrosDeConexion(); // sin configurar

                var json = File.ReadAllText(archivo, Encoding.UTF8);
                var bytes = Encoding.UTF8.GetBytes(json);
                using (var ms = new MemoryStream(bytes))
                {
                    var serializer = new DataContractJsonSerializer(typeof(ParametrosDeConexion));
                    var obj = (ParametrosDeConexion)serializer.ReadObject(ms);
                    return obj ?? new ParametrosDeConexion();
                }
            }
            catch (Exception)
            {
                // Si el archivo está corrupto (p. ej. XML), devolvemos valores por defecto
                // y permitimos que la app muestre el formulario de configuración.
                return new ParametrosDeConexion();
            }
        }

        public static bool probarConexion(ParametrosDeConexion parametros, out string error)
        {
            try
            {
                using (var cn = new SqlConnection(parametros.cadenaConexion))
                {
                    cn.Open();
                    error = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
