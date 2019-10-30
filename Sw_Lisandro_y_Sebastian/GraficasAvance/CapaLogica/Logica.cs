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
        public void cargarComboBox(object sender, EventArgs e, ComboBox cmbx, string consulta)
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
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * 
             * Descripcion: Funcion para devolver el numero de subobjetivos dependiendo
             * el objetivo seleccionado
             * ...
             * 
             */

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
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * 
             * Descripcion: Funcion para devolver el valor porcentual de cada objetivo
             * Por ejemplo: Si el objetivo 1 tiene 15 subobjetivos, cada subobjetivo tendria
             * un valor de 6.6666667
             * ...
             * 
             */
            int porcentajeTotal = 100;
            double valorPorcentualSubobjetivo = porcentajeTotal / contarSubobjetivos(idObjetivo);

            return valorPorcentualSubobjetivo;
        }
        public string ObtenerNombreTabla(ComboBox Cbo_seleccion)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             * 
             * Descripcion: Funcion para obtner el nombre de la tabla
             * en la base de datos, dependiendo la seleccion 
             * ...
             * 
             */

            string tabla = "";

            if (Cbo_seleccion.SelectedIndex == 0)
            {
                tabla = "tbl_normativa";
            }
            else if (Cbo_seleccion.SelectedIndex == 1)
            {
                tabla = "tbl_dominio";
            }
            else if (Cbo_seleccion.SelectedIndex == 2)
            {
                tabla = "tbl_objetivo";
            }
            else if (Cbo_seleccion.SelectedIndex == 3)
            {
                tabla = "tbl_subobjetivo";
            }

            return tabla;
        }
        public string[] ObtenerProgresoFromListBox(ListBox Lst_datos_grafica, ComboBox Cbo_seleccion)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             * 
             * Descripcion: Funcion para mover obtener el progreso de avance de 
             * cada item en la lista.
             * ...
             * 
             */

            string[] datos_grafica = Lst_datos_grafica.Items.OfType<string>().ToArray();
            string[] progreso = new string[2500];
            int itemsTotal = Lst_datos_grafica.Items.Count;

            /* Obteniendo el progreso por cada item en Lst_datos_grafica y guardandolo
             * en un arreglo
             * 
             */

         

            for (int i = 0; i < datos_grafica.Length; i++)
            {
                try
                {
                    ConectarServidor miConexion = new ConectarServidor();
                    string sentencia = "SELECT Progreso FROM " + ObtenerNombreTabla(Cbo_seleccion) +
                                       " WHERE Nombre = " + "'" +
                                       Convert.ToString(Lst_datos_grafica.Items[i] + "'");

                    OdbcCommand comando = new OdbcCommand(sentencia, miConexion.Conexion());
                    OdbcDataReader lector_query = comando.ExecuteReader();

                    while (lector_query.Read())
                    {
                        progreso[i] = lector_query.GetString(0);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }           
            }
            return progreso;
        }


  

    }
}
