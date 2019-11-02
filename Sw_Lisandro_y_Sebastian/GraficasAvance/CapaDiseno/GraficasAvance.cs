using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;
using System.Data.Odbc;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;



namespace CapaDiseno
{
    public partial class GraficasAvance : Form
    {
        public GraficasAvance()
        {
            InitializeComponent();
        }
        private void GraficasAvance_Load(object sender, EventArgs e)
        {
            /*Logica logica = new Logica();
            logica.cargarComboBox(this, e, Cbo_dominios, "SELECT Nombre FROM bdauditoria.tbl_objetivo WHERE PK_Id_Objetivo > -1");
            */
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.Btn_mover_derecha, "Mueve un elemento a \n" +
                                                        "a la lista de datos a graficar");

            toolTip1.SetToolTip(this.Btn_mover_todos_derecha, "Mueve todos los elementos a \n" +
                                                              "a la lista de datos a graficar");

            toolTip1.SetToolTip(this.Btn_mover_izquierda, "Mueve un elemento a \n" +
                                                          "a la lista de datos");

            toolTip1.SetToolTip(this.Btn_mover_todos_izquierda, "Mueve todos los elementos a \n" +
                                                              "a la lista de datos");

            toolTip1.SetToolTip(this.Cbo_seleccion,  "Muestra secciones de la norma \n" +
                                                     "disponibles as escoger");

            toolTip1.SetToolTip(this.Cbo_tipo_grafica, "Muestra tipos de graficas disponibles \n" +
                                                       "para mostrar los datos");

            toolTip1.SetToolTip(this.Btn_crear_grafica, "Crea una grafica con los datos de la \n" +
                                                        "lista de datos a graficar");



        }
        private void Cbo_seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             *
             * Descripcion: LLena Lst_datos_a_elegir con los datos de la 
             * opcion seleccionada en el combobox Cbo_seleccion
             * ...
             */

            Lst_datos_grafica.Items.Clear();


            if (Cbo_seleccion.SelectedIndex == 0)
            {
                // Si la opcion normativa es seleccionada, mostrar todas las normativas almacenadas

                // Borrando datos anteriores del listbox
                Lst_datos_a_elegir.Items.Clear(); 

                try
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT Nombre FROM tbl_normativa";

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {

                        Lst_datos_a_elegir.Items.Add(queryResultsReader.GetString(0));
                    }

                    cn.CerrarConexion();

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                }

            }
            else if (Cbo_seleccion.SelectedIndex == 1)
            {
                // Si la opcion dominio es seleccionada, mostrar todos los dominios

                // Borrando datos anteriores del listbox
                Lst_datos_a_elegir.Items.Clear();

                try
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT Nombre FROM tbl_dominio";

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {

                        Lst_datos_a_elegir.Items.Add(queryResultsReader.GetString(0));
                    }

                    cn.CerrarConexion();

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                }
            }

            else if (Cbo_seleccion.SelectedIndex == 2)
            {
                // Si la opcion objetivos es seleccionada, mostrar todos los objetivos

                // Borrando datos anteriores del listbox
                Lst_datos_a_elegir.Items.Clear();

                try
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT Nombre FROM tbl_objetivo";

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {

                        Lst_datos_a_elegir.Items.Add(queryResultsReader.GetString(0));
                    }

                    cn.CerrarConexion();

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                }
            }

            else if (Cbo_seleccion.SelectedIndex == 3)
            {
                // Si la opcion subobjetivo es seleccionada, mostrar todos los subobjetivos

                // Borrando datos anteriores del listbox
                Lst_datos_a_elegir.Items.Clear();

                try
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT Nombre FROM tbl_subobjetivo";

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {

                        Lst_datos_a_elegir.Items.Add(queryResultsReader.GetString(0));
                    }

                    cn.CerrarConexion();

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                }
                
            }


        }
        private void Btn_mover_derecha_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * Descripcion: Mueve el dato seleccionado a la lista de datos de grafica
             * 
             */

            if (Lst_datos_a_elegir.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de seleccionar un item");
            }
            else
            {

                string itemSeleccionado = (string)Lst_datos_a_elegir.SelectedItem;
                Lst_datos_grafica.Items.Add(itemSeleccionado);
                Lst_datos_a_elegir.Items.Remove(itemSeleccionado);
            }


        }
        private void Btn_mover_izquierda_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 27/10/2019
             * Descripcion: Mueve el dato seleccionado de regreso
             * 
             */

            if (Lst_datos_grafica.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar item");
            }
            else
            {
                string itemSeleccionado = (string)Lst_datos_grafica.SelectedItem;
                Lst_datos_a_elegir.Items.Add(itemSeleccionado);
                Lst_datos_grafica.Items.Remove(itemSeleccionado);
            }
        }
        private void Btn_mover_todos_derecha_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             * Descripcion: Mueve todos los items de la lst_datos_a_elegir a lst_datos_grafica 
             * 
             */
           
            for (int j = 0; j <= Lst_datos_a_elegir.Items.Count - 1; j++)
            {
                Lst_datos_grafica.Items.Add(Lst_datos_a_elegir.Items[j]);
            }
            Lst_datos_a_elegir.Items.Clear();
        }
        private void Btn_mover_todos_izquierda_Click(object sender, EventArgs e)
        {
            /* Fecha:28/10/2019 
             * Autor:Victor Fernandez
             * Descripcion: Mueve todos los items de la lst_datos_grafica a
             * lst_datos_a_elegir
             */

            for (int j = 0; j <= Lst_datos_grafica.Items.Count - 1; j++)
            {
                Lst_datos_a_elegir.Items.Add(Lst_datos_grafica.Items[j]);
            }
            Lst_datos_grafica.Items.Clear();
        }
        private void CrearGraficaBarras(ListBox miListBox, ComboBox seleccion)
        {
            /* Autor: Victor Fernandez
             * Fecha: 28/10/2019
             * 
             * Descripcion: Metodo para crear una grafica basandose en la seleccion del
             * primer ComboBox
             * ...
             * 
             */

            Logica pLogica = new Logica();


            // Eliminando grafica anterior
            Chart_avance.Series.Clear();
            Chart_avance.Titles.Clear();

            Chart_avance.ChartAreas[0].AxisX.Title = seleccion.SelectedText;
            Chart_avance.ChartAreas[0].AxisY.Title = "Avance (%)";


            Chart_avance.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            Chart_avance.ChartAreas[0].AxisX.Interval = 1;
           
            Chart_avance.ChartAreas[0].AxisX.LabelStyle.Angle = -35;
            Chart_avance.Series.Add("Progreso");
            
             for (int i = 0; i < Lst_datos_grafica.Items.Count; i++)
             {
               
                 // Chart_avance.Series.Add(Convert.ToString(miListBox.Items[i]));
                 /*Chart_avance.Series[Convert.ToString(miListBox.Items[i])].Points.AddXY(miListBox.Items[i],
                                     pLogica.ObtenerProgresoFromListBox(Lst_datos_grafica, seleccion)[i]);*/


                Chart_avance.Series["Progreso"].Points.AddXY(miListBox.Items[i],
                                     pLogica.ObtenerProgresoFromListBox(Lst_datos_grafica, seleccion)[i]);

            }
             


            Chart_avance.Titles.Add("Porcentaje de avance " + Convert.ToString(Cbo_seleccion.SelectedItem));
        }
        private void Btn_crear_grafica_Click(object sender, EventArgs e)
        {
                if (Cbo_seleccion.SelectedIndex == 1)
                {
                    Logica plogica = new Logica();
                    plogica.CalcularAvanceObjetivos(Lst_datos_grafica);
                    plogica.CalcularAvanceDominios(Lst_datos_grafica);
                }

                if (Cbo_seleccion.SelectedIndex == 2)
                {
                    Logica plogica = new Logica();
                    plogica.CalcularAvanceObjetivos(Lst_datos_grafica);
                }

                CrearGraficaBarras(Lst_datos_grafica, Cbo_seleccion);
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
