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

                cn.CerrarConexion();

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
                string comando = "SELECT COUNT(Nombre) FROM tbl_subobjetivo WHERE tbl_objetivo_PK_Id_objetivo =" + Convert.ToString(idObjetivo);

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
                   // Conviertiendo el resultado a entero para poder enviarlo en el return 
                   totalSubobjetivos = Convert.ToInt32(queryResultsReader.GetString(0));
                }

                cn.CerrarConexion();
            }

            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error ContarSubobjetivos");
            }

            return totalSubobjetivos;
        }
        public int contarObjetivos(int idDominio)
        {
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * 
             * Descripcion: Funcion para devolver el numero de objetivos dependiendo
             * el dominio seleccionado
             * ...
             * 
             */

            int totalObjetivos = 0;

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT COUNT(Nombre) FROM tbl_objetivo " +
                                 "WHERE tbl_dominio_PK_Id_dominio = " + Convert.ToString(idDominio);

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
                    // Conviertiendo el resultado a entero para poder enviarlo en el return 
                    totalObjetivos = Convert.ToInt32(queryResultsReader.GetString(0));
                }

                cn.CerrarConexion();

            }

            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error ContarObjetivos");
            }

            return totalObjetivos;
        }
        public double calcularValorPorcentualSubobjetivo(int idObjetivo)
        {
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * 
             * Descripcion: Funcion para devolver el valor porcentual de cada subobjetivo o objetivos
             * Por ejemplo: Si el objetivo 1 tiene 15 subobjetivos, cada subobjetivo tendria
             * un valor de 6.6666667
             * ...
             * 
             */

            int porcentajeTotal = 100;
            double valorPorcentualSubobjetivo = 0;

            /* Evitando division entre 0 */
            if (contarSubobjetivos(idObjetivo) != 0)
            {
                return valorPorcentualSubobjetivo = porcentajeTotal / contarSubobjetivos(idObjetivo);
            }

            return valorPorcentualSubobjetivo;
        }
        public double calcularValorPorcentualObjetivo(int idDominio)
        {
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * 
             * Descripcion: Funcion para devolver el valor porcentual de cada objetivo
             * 
             */

            int porcentajeTotal = 100;
            double valorPorcentualObjetivo = 0;

            /* Evitando division entre 0 */
            if (contarObjetivos(idDominio) != 0)
            {
                return valorPorcentualObjetivo = porcentajeTotal / contarObjetivos(idDominio);
            }

            return valorPorcentualObjetivo;
        }
        public string ObtenerNombreTabla(ComboBox Cbo_seleccion)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             * 
             * Descripcion: Funcion para obtner el nombre de la tabla
             * en la base de datos, dependiendo la seleccion del combobox
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

            /* Cambiarlo, hacerlo dinamico*/
            string[] progreso = new string[2500];

            int itemsTotal = Lst_datos_grafica.Items.Count;

            /* Obteniendo el progreso por cada item en Lst_datos_grafica y guardandolo
             * en un arreglo
             */    

            for (int i = 0; i < datos_grafica.Length; i++)
            {
                try
                {
                    ConectarServidor miConexion = new ConectarServidor();
                    string sentencia = "SELECT Progreso FROM " + ObtenerNombreTabla(Cbo_seleccion) +
                                       " WHERE Nombre = " + "'" +
                                       Convert.ToString(Lst_datos_grafica.Items[i]) + "'";

                    OdbcCommand comando = new OdbcCommand(sentencia, miConexion.Conexion());
                    OdbcDataReader lector_query = comando.ExecuteReader();

                    while (lector_query.Read())
                    {
                        progreso[i] = lector_query.GetString(0);
                    }

                    miConexion.CerrarConexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Error ObtenerProgresoFromListBox");
                }           
            }
            return progreso;
        }
        public void CalcularAvanceObjetivos(ListBox datos_a_graficar)
        {
            /* Autor: Victor Fernandez
             * Fecha: 29/10/2019
             * Descripcion: Funcion para calcular el avance de objetivos
             */

            int numeroObjetivo = 0;
            int numeroDeDatosAGraficar = datos_a_graficar.Items.Count;

            double valorPorcentual = 0;
            double avanceObjetivo = 0;

            for (int i = 0; i < numeroDeDatosAGraficar; i++) {
                try
                {
                    // Reiniciando el avance para poder calcular el siguiente avance
                    avanceObjetivo = 0;

                    ConectarServidor cn = new ConectarServidor();
                    // Obteniendo el valor porcentual de cada subobjetivo

                        // Obteniedo el numero de subobjetivos de cada objetivo

                    string comando_obtener_id_objetivo = "SELECT PK_Id_Objetivo FROM tbl_objetivo " +
                                                         " WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "'"; 

                    OdbcCommand command = new OdbcCommand(comando_obtener_id_objetivo, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();


                    while (queryResultsReader.Read())
                    {
                        // Numero de subobjetivos 
                        numeroObjetivo = (Convert.ToInt32(queryResultsReader.GetString(0)));
                    }

                    cn.CerrarConexion();
                }

                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("CalcularAvanceObjetivos");
                }

                try
                {
                    ConectarServidor cn = new ConectarServidor();

                    valorPorcentual = calcularValorPorcentualSubobjetivo(numeroObjetivo);

                    string comando = "SELECT Progreso FROM tbl_subobjetivo " +
                                 "WHERE tbl_objetivo_PK_Id_Objetivo = " +
                                 "(SELECT PK_Id_Objetivo FROM tbl_objetivo " +
                                 "WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "')";



                    // Sumando el valor de cada subobjetivo perteneciente al respectivo objetivo

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {
                        avanceObjetivo += (Convert.ToDouble(queryResultsReader.GetString(0)) / 100) * valorPorcentual;
                    }

                    comando = "UPDATE tbl_objetivo " +
                              " SET Progreso = " + Convert.ToString(avanceObjetivo) +
                              " WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "'";



                    command = new OdbcCommand(comando, cn.Conexion());
                    queryResultsReader = command.ExecuteReader();

                    cn.CerrarConexion();

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    //MessageBox.Show(ex.Message);
                    //MessageBox.Show("CalcularAvanceObjetivos2");
                }
            }

      

        }
        public void CalcularAvanceDominios(ListBox datos_a_graficar)
        {
            /* Autor: Victor Fernandez
             * Fecha: 29/10/2019
             * Descripcion: Funcion para calcular el avance de dominios 
             */

            int numeroDominio = 0;
            int numeroDeDatosAGraficar = datos_a_graficar.Items.Count;

            double valorPorcentual = 0;
            double avanceDominio = 0;




            for (int i = 0; i < numeroDeDatosAGraficar; i++)
            {

                try
                {
                    // Reiniciando el avance para poder calcular el siguiente avance
                    avanceDominio = 0;

                    ConectarServidor cn = new ConectarServidor();

                    // Obteniendo el valor porcentual de cada subobjetivo

                    // Obteniedo el numero de subobjetivos de cada objetivo



                    string comando_obtener_id_dominio = "SELECT PK_Id_dominio FROM tbl_dominio " +
                                                         " WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "'";




                    OdbcCommand command = new OdbcCommand(comando_obtener_id_dominio, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();


                    while (queryResultsReader.Read())
                    {
                        // Numero de subobjetivos 
                        numeroDominio = (Convert.ToInt32(queryResultsReader.GetString(0)));
                    }


                    cn.CerrarConexion();
                }

                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("CalcularAvanceDominios");
                }

                try
                {
                    ConectarServidor cn = new ConectarServidor();

                    valorPorcentual = calcularValorPorcentualObjetivo(numeroDominio);

                    string comando = "SELECT Progreso FROM tbl_objetivo " +
                                 "WHERE tbl_dominio_PK_Id_dominio = " +
                                 "(SELECT PK_Id_dominio FROM tbl_dominio " +
                                 "WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "')";



                    // Sumando el valor de cada subobjetivo perteneciente al respectivo objetivo

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {
                        avanceDominio += (Convert.ToDouble(queryResultsReader.GetString(0)) / 100) * valorPorcentual;
                    }

                    comando = "UPDATE tbl_dominio " +
                              " SET Progreso = " + Convert.ToString(avanceDominio) +
                              " WHERE Nombre = " + "'" + datos_a_graficar.Items[i] + "'";



                    command = new OdbcCommand(comando, cn.Conexion());
                    queryResultsReader = command.ExecuteReader();

                    cn.CerrarConexion();


                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    //MessageBox.Show(ex.Message);
                    //MessageBox.Show("CalcularAvanceObjetivos2");
                }
            }

        }


    }
}
