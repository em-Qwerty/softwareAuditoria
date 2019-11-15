using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace capa_datos_relacion_departamentos
{
    public class DatosRelacionDepto
    {

        //INSTANCIA DE CLASE PARA CONEXION ODBC
        OdbcConnection conn = new OdbcConnection("dsn=dsnAuditoria");

        //MÉTODO PARA ESTABLECER CONEXIÓN
        public OdbcConnection Conectar()
        {
            try
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("conectado");
                    return conn;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            return null;

        }

        //MÉTODO PARA DESCONECTAR
        public OdbcConnection Desconectar()
        {
            try
            {
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                {
                    return conn;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            return null;

        }
    }
}
