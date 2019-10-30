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



namespace CapaDiseno
{
    public partial class GraficasAvance : UserControl
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
                MessageBox.Show("Seleccionar item");
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
        private void CrearGrafica(ListBox miListBox, ComboBox seleccion)
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

            for (int i = 0; i < Lst_datos_grafica.Items.Count; i++)
            {
                Chart_avance.Series.Add(Convert.ToString(miListBox.Items[i]));
                Chart_avance.Series[Convert.ToString(miListBox.Items[i])].Points.AddXY(miListBox.Items[i],
                                                    pLogica.ObtenerProgresoFromListBox(Lst_datos_grafica, 
                                                    seleccion)[i]);

            }

            Chart_avance.Titles.Add("Porcentaje de avance " + Convert.ToString(Cbo_seleccion.SelectedItem));
        }
        private void Btn_crear_grafica_Click(object sender, EventArgs e)
        {
            CrearGrafica(Lst_datos_grafica, Cbo_seleccion);
        }
    }
}
