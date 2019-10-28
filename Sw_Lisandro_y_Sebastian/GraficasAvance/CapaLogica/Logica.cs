using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaDatos;
using System.Data.Common;
using System.Reflection;
using System.Windows.Forms;
using System.Data.Odbc;

// Fill()




namespace CapaLogica
{
    public class Logica
    {
        public void cargarDominios(object sender, EventArgs e, System.Windows.Forms.ComboBox cmbx, string consulta)
         {
            // 27/10/2019 Autor: Victor Fernandez
            // Esta funcion carga los resultados de una columna (de uan consulta) al
            // combobox

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = consulta;

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion()); 
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
              
                    cmbx.Items.Add(queryResultsReader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
