using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;



namespace CapaDatos
{
    public class ConectarServidor
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnauditoria;");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
        public OdbcConnection CerrarConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnauditoria;");
            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
    }
}
