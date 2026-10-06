using System.Configuration;
using System.Data.SqlClient;

namespace TaskDB
{
    /// <summary>
    /// Punto único de acceso a la base de datos TaskDB.mdf (SQL Server LocalDB).
    /// Los formularios piden aquí la conexión en lugar de escribir la cadena cada uno.
    /// </summary>
    public static class DatabaseConnection
    {
        // Nombre de la entrada en la sección <connectionStrings> de App.config.
        private const string NombreCadena = "TaskDB";

        // Cadena de respaldo por si App.config no trae la entrada.
        // |DataDirectory| se reemplaza en tiempo de ejecución por la carpeta del ejecutable,
        // así la ruta de TaskDB.mdf no queda fija a una máquina.
        private const string CadenaPorDefecto =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\TaskDB.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Cadena de conexión hacia TaskDB.mdf.
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings[NombreCadena];
                return configuracion != null ? configuracion.ConnectionString : CadenaPorDefecto;
            }
        }

        /// <summary>
        /// Devuelve una conexión nueva y cerrada; quien la pide la abre dentro de un bloque using.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
