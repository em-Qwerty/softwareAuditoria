using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class Conexion
    {
        public MySqlConnection probarConexion()
        {
            MySqlConnection conn = new MySqlConnection();
            string myConnectionString;

            myConnectionString = "Server=localhost;Database=; Uid=root;Pwd='';";

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("No se pudo conectar con la base de datos");
            }
            return conn;
        }

    }
}
