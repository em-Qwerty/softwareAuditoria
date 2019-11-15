using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaDatos
{
    public class Sentencia
    {
        public OdbcDataReader consultaBD(string comando)
        {
            ConectarServidor cn = new ConectarServidor();
           

            OdbcCommand query = new OdbcCommand(comando, cn.Conexion());
            OdbcDataReader queryResults = query.ExecuteReader();

            return queryResults;
            

        }
    }
}
