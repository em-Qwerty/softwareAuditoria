using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class Sentencia
    {
        public MySqlDataAdapter consultaBD(string dato, string campo, string tabla)
        {
            Conexion cn = new Conexion();
            cn.probarConexion();
            string sql = "SELECT * FROM " + tabla + " WHERE " + campo + "='" + dato + "';";
            MySqlDataAdapter dataTable = new MySqlDataAdapter(sql, cn.probarConexion());
            return dataTable;
        }
    }
}
