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
            // Fecha:28/10/2019 Autor:Victor Fernandez
            // LLena Lst_datos_a_elegir con los datos de la opcion seleccionada en el combobox Cbo_seleccion
            
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
            // Fecha:28 / 10 / 2019 Autor: Victor Fernandez
            // Mueve el dato seleccionado a la otra lista

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
            // Fecha:28/10/2019 Autor:Victor Fernandez
            // Mueve el dato seleccionado a la otra lista

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
            // Fecha:28/10/2019 Autor:Victor Fernandez
            // Mueve todos los items de la lst_datos_a_elegir a lst_datos_grafica 

            for (int j = 0; j <= Lst_datos_a_elegir.Items.Count - 1; j++)
            {
                Lst_datos_grafica.Items.Add(Lst_datos_a_elegir.Items[j]);
            }
            Lst_datos_a_elegir.Items.Clear();
        }

        private void Btn_mover_todos_izquierda_Click(object sender, EventArgs e)
        {
            // Fecha:28/10/2019 Autor:Victor Fernandez
            // Mueve todos los items de la lst_datos_grafica a lst_datos_a_elegir

            for (int j = 0; j <= Lst_datos_grafica.Items.Count - 1; j++)
            {
                Lst_datos_a_elegir.Items.Add(Lst_datos_grafica.Items[j]);
            }
            Lst_datos_grafica.Items.Clear();
        }




        private void CrearGrafica(ListBox miListBox)
        {
            // Fecha: 28/10/2019 Autor: Victor Fernandez
            // Esta funcion crea la grafica a partir de los datos en miListBox



            // separar esta funcion en 2, una para obtener el progreso y otra para crear la grafica

            // Pasando todos los items de miListBox a un arreglo
            string[] clist = miListBox.Items.OfType<string>().ToArray();

            // string para guardar el nombre de la tabla
            string tabla = "";

            // Array para guardar el progreso de cada normativa/dominio/objetivo/subobj.
            // Nota: modificar para que sea dinamico
            string[] progreso = new string[2500];

            int itemsTotal = miListBox.Items.Count;

            Chart_avance.Series.Clear();

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

            // Obteniendo el progreso por cada item en miListBox y guardandolo en un arreglo
            for (int i = 0; i < clist.Length - 1; i++)
            {
                try
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT progreso FROM " + tabla + " WHERE Nombre =" + "'" + Convert.ToString(miListBox.Items[i] + "'");


                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {
                        progreso[i] = queryResultsReader.GetString(0); // obtiene la columna 0

                    }

                }
                catch (Exception ex)
                {
                    // Mostrando mensaje que indica el error 
                    MessageBox.Show(ex.Message);
                }

            }



            for (int i = 0; i < itemsTotal; i++)
            {
                Chart_avance.Series.Add(Convert.ToString(miListBox.Items[i]));
                Chart_avance.Series[Convert.ToString(miListBox.Items[i])].Points.AddXY(miListBox.Items[i], progreso[i]);

            }

            Chart_avance.Titles.Add("Porcentaje de avance " + Convert.ToString(Cbo_seleccion.SelectedItem));
            

        }

        private void Btn_crear_grafica_Click(object sender, EventArgs e)
        {
            
            CrearGrafica(Lst_datos_grafica);
        }
    }
}
