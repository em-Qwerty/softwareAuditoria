using CapaDatos;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Logica
    {
        private string nombreProyecto = "";
        private string normativaProyecto = "";

        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public string NormativaProyecto { get => normativaProyecto; set => normativaProyecto = value; }

        public string ObtenerNormativaProyecto(ComboBox Cbo)
        {
            /* Autor: Victor Fernandez
             * Fecha: 7/10/2019
             *
             * Descripcion: Obtiene el id de la normativa del proyecto que se selecciono
             * ...
             */


            nombreProyecto = (Cbo.GetItemText(Cbo.SelectedItem));   
            normativaProyecto = "";

            // Obteniendo que normativa utiliza el proyecto
            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT tbl_normativa_Pk_Id_normativa FROM tbl_proyecto " +
                                 "WHERE (estatus = 0) AND (nombre_Proyecto = '" + NombreProyecto + "')";

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
                    normativaProyecto = queryResultsReader.GetString(0);
                }

                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }
            return normativaProyecto;
        }
        public void ObtenerDominiosNormativa(ComboBox Cbo, ListBox Lst)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Metodo para llenar un listbox con los dominios de la
             * normativa en uso. 
             */

            // Obteniendo la normativa del proyecto seleccionado
            ObtenerNormativaProyecto(Cbo);


            // Obteniendo los dominios de la normativa
            try
            {

                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT Nombre FROM tbl_dominio " +
                                 "WHERE estatus = 0 AND tbl_normativa_PK_Id_normativa = " + NormativaProyecto;

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {
                    Lst.Items.Add(queryResultsReader.GetString(0));
                }

                cn.CerrarConexion();

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }
        }
        public void ObtenerObjetivos(ComboBox Cbo, ListBox Lst)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Llena el combobox con los objetivos de los dominios
             * seleccionados
             */

            try
            {

                for (int i = 0; i < Lst.Items.Count; i++)
                {
                    ConectarServidor cn = new ConectarServidor();
                    string comando = "SELECT Nombre FROM tbl_objetivo " +
                                     "WHERE estatus = 0 AND " +
                                     "  (SELECT PK_Id_dominio FROM tbl_dominio " +
                                     "   WHERE estatus = 0 AND tbl_normativa_PK_Id_normativa = " + normativaProyecto +
                                     "   AND Nombre = '" + Lst.Items[i] + "') = tbl_dominio_Pk_Id_dominio";

                    OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                    OdbcDataReader queryResultsReader = command.ExecuteReader();

                    while (queryResultsReader.Read())
                    {
                        //Lst_seleccion_dominios.Items.Add(queryResultsReader.GetString(0));
                        Cbo.Items.Add(queryResultsReader.GetString(0));
                    }

                    cn.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }
        }
        public void ObtenerProyectos(ComboBox Cbo)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Obtiene todos los proyectos disponibles en la base de datos
             */

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT nombre_proyecto FROM tbl_proyecto " +
                                 "WHERE estatus = 0";

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {

                    Cbo.Items.Add(queryResultsReader.GetString(0));
                }

                cn.CerrarConexion();

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }

        }
        public string ObtenerIdObjetivo(ComboBox Cbo)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Obtiene el id del objetivo seleccionado
             */

            string objetivo = Cbo.GetItemText(Cbo.SelectedItem);
            string idObjetivo = "";

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT PK_Id_Objetivo FROM tbl_objetivo " +
                                 "WHERE estatus = 0 AND Nombre = '" + objetivo + "'";

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {

                    idObjetivo = queryResultsReader.GetString(0);
                }

                cn.CerrarConexion();

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }

            return idObjetivo;
        }
        public void ObtenerAuditores(ComboBox Cbo)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Llena cbo con todos los auditores registrados
             * 
             */

            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = "SELECT nombre FROM tbl_auditores " +
                                 "WHERE estatus = 0";

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion());
                OdbcDataReader queryResultsReader = command.ExecuteReader();

                while (queryResultsReader.Read())
                {

                    Cbo.Items.Add(queryResultsReader.GetString(0));
                }

                cn.CerrarConexion();

            }
            catch (Exception ex)
            {
                // Mostrando mensaje que indica el error 
                MessageBox.Show(ex.Message);
            }


        }
        public void CargarDatos(DataGridView Dgv, ComboBox Cbo, ComboBox Cbo2, ComboBox Cbo_avance_min, ComboBox Cbo_avance_max)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Carga los subobjetivos al datagrid
             */

            string objetivo = Cbo.GetItemText(Cbo.SelectedItem);
            string idObjetivo = "";

            string avance_min = Cbo_avance_min.GetItemText(Cbo_avance_min.SelectedItem);
            string avance_max = Cbo_avance_max.GetItemText(Cbo_avance_max.SelectedItem);


            // Removiendo datos anteriores
            while (Dgv.Rows.Count > 0)
            {
                Dgv.Rows.RemoveAt(0);
            }

            idObjetivo = ObtenerIdObjetivo(Cbo);

            if (idObjetivo != "")
            {

                try
                {

                    OdbcConnection conexion = new OdbcConnection("Dsn=dsnauditoria;");
                    OdbcDataAdapter da;
                    DataSet ds;
                    string comando = "";


                    if (Cbo2.GetItemText(Cbo2.SelectedItem) == "Todos")
                    {
                        comando = "SELECT tbl_subobjetivo.Nombre AS Subobjetivo, " +
                                  "tbl_subobjetivo.Progreso AS 'Porcentaje de Avance', " +
                                  "tbl_auditores.nombre AS 'Auditor encargado' FROM tbl_subobjetivo " +
                                  "INNER JOIN tbl_auditores ON tbl_subobjetivo.tbl_auditores_PK_carnet = tbl_auditores.Pk_carnet " +
                                  "WHERE tbl_subobjetivo.estatus = 0 AND tbl_auditores.estatus = 0 AND tbl_objetivo_PK_Id_objetivo = " + idObjetivo + " " +
                                  "AND tbl_subobjetivo.progreso >= " + avance_min + " AND tbl_subobjetivo.progreso <= " + avance_max;
                    }

                    if (Cbo2.GetItemText(Cbo2.SelectedItem) != "Todos")
                    {

                        comando = "SELECT tbl_subobjetivo.Nombre AS Subobjetivo, " +
                                  "tbl_subobjetivo.Progreso AS 'Porcentaje de Avance', " +
                                  "tbl_auditores.nombre AS 'Auditor encargado' FROM tbl_subobjetivo " +
                                  "INNER JOIN tbl_auditores ON tbl_subobjetivo.tbl_auditores_PK_carnet = tbl_auditores.Pk_carnet " +
                                  "WHERE tbl_subobjetivo.estatus = 0 AND tbl_auditores.estatus = 0 AND tbl_objetivo_PK_Id_objetivo = " + idObjetivo + " " +
                                  "AND tbl_auditores.nombre = '" + Cbo2.GetItemText(Cbo2.SelectedItem) + "' " +
                                  "AND tbl_subobjetivo.progreso >= " + avance_min + " AND tbl_subobjetivo.progreso <= " + avance_max;
                    }



                    

                    da = new OdbcDataAdapter(comando, conexion);
                    ds = new DataSet();
                    da.Fill(ds);
                    conexion.Close();

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        Dgv.DataSource = ds.Tables[0];
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
}
