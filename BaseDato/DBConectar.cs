// Referencias del proyecto
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDato
{
    public class DBConectar
    {
        public static string ConnectionString // Creamos una propiedad para obtener la cadena de conexión de la base de datos que queramos usar
        {
            get // definimos loque queremos obtener, dentro del get
            {
                // Obtiene directamente la cadena de conexión con el nombre que le asignamos en "app.config"
                string CadenaConexion =
                    ConfigurationManager.
                    ConnectionStrings["NWConnection"]
                    .ConnectionString; 
                /////////////////////

                // Crea un nuevo objeto usando la cadena de conexion
                SqlConnectionStringBuilder conexionBuilder = 
                    new SqlConnectionStringBuilder(CadenaConexion); //Se utiliza para cambiar los diferentes elementos respecto a la base de datos
                ///////////////////// (Auto referenciación)

                // Definimos el nombre de la aplicación (si no es nulo)
                conexionBuilder.ApplicationName = 
                    ApplicationName ?? conexionBuilder.ApplicationName;
                /////////////////////

                // Definimos el tiempo de espera de la conexion (si es mayor a 0, sino que use el valor por defecto)
                conexionBuilder.ConnectTimeout =
                    (ConnectionTimeout > 0) ? ConnectionTimeout : conexionBuilder.ConnectTimeout;
                /////////////////////
                
                // Retornamos la nueva conexión como una cadena de texto
                return conexionBuilder.ToString();
                /////////////////////
            }
        }
        public static string ApplicationName { get; set; } // Definimos la propiedad para el Nombre de la aplicación
        public static int ConnectionTimeout { get; set; } // Definimos la propiedad para el tiempo de conexión

        // Definimos un metodo para obtener una conexion SQL
        public static SqlConnection GetSql()
        {
            SqlConnection conexion = new SqlConnection(ConnectionString); // crea una nueva conexión en base a la que obtuvimos antes
            conexion.Open(); // Abre la conexión a la base de datos
            return conexion; // Retorna la conexión abierta
        }
        /////////////////////
    }
}

     
