using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaDatos;

namespace CapaLogica
{
    public class Logica
    {
        public DataTable consultaLogica(string dato, string campo, string tabla)  //obtener datos de la consulta
        {
            Sentencia sn = new Sentencia();
            MySqlDataAdapter dt = sn.consultaBD(dato, campo, tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
