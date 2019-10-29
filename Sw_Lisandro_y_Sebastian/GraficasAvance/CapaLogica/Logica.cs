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
        public void cargarComboBox(object sender, EventArgs e, System.Windows.Forms.ComboBox cmbx, string consulta)
         {
            // 27/10/2019 Autor: Victor Fernandez
            // Este metodo carga los resultados de una columna (de uan consulta) al
            // combobox pasado como parametro

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



        public int contarSubobjetivos(int idObjetivo)
        {
            // 27/10/2019 Autor: Victor Fernandez
            // Esta funcion devuelve el numero de subobjetivos dependiendo el objetivo 

            int totalSubobjetivos = 0;

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT COUNT(Nombre) AS NumeroSubobjetivos FROM tbl_subobjetivo WHERE tbl_objetivo_PK_Id_objetivo =" + idObjetivo;

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
                   // Conviertiendo el resultado a entero para poder enviarlo en el return 
                   totalSubobjetivos = Convert.ToInt32(queryResultsReader.GetString(0));
                }

            }

            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }

            return totalSubobjetivos;
        }

        public double calcularValorPorcentualSubobjetivo(int idObjetivo)
        {
            // 27/10/2019 Autor: Victor Fernandez
            // Esta funcion devuelve el valor porcentual de cada subobjetivo
            // Por ejemplo:
            // Si el objetivo 1 tiene 15 subobjetivos, cada subobjetivo tendria un valor de 6.6666667
          

            int porcentajeTotal = 100;
            double valorPorcentualSubobjetivo = porcentajeTotal / contarSubobjetivos(idObjetivo);

            return valorPorcentualSubobjetivo;
        }




    }
}
