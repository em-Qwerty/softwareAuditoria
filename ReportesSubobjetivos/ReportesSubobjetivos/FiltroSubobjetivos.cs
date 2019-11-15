using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.Odbc;
using CapaLogica;
using ventanaDiseno;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CrystalDecisions.ReportAppServer;




namespace ReportesSubobjetivos
{
    public partial class FiltroSubobjetivos : Form
    {

        Logica reportesSubobjetivos = new Logica();
      

        public FiltroSubobjetivos()
        {
            InitializeComponent();
            
        }
        private void CargarToolTips()
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: Muestra un cuadro que describe
             * lo que hace el objeto al pasar el mouse encima 
             * 
             * 
             */ 

            ToolTip toolTip1 = new ToolTip();

            toolTip1.ShowAlways = true;
            // Muestra el ToolTip como un globo de texto
            toolTip1.IsBalloon = true;
            // Asigna el ToolTip a cada boton.
            toolTip1.SetToolTip(this.Btn_mover_derecha, "Mueve un elemento a \n" +
                                                        "a la lista de dominios seleccionados");

            toolTip1.SetToolTip(this.Btn_mover_todos_derecha, "Mueve todos los elementos a \n" +
                                                              "a la lista de dominios seleccionados");

            toolTip1.SetToolTip(this.Btn_mover_izquierda, "Mueve un elemento a \n" +
                                                          "a la lista izquierda");

            toolTip1.SetToolTip(this.Btn_mover_todos_izquierda, "Mueve todos los elementos a \n" +
                                                              "a la lista izquierda");

            toolTip1.SetToolTip(this.Cbo_auditores, "Combobox para seleccionar auditor");

            toolTip1.SetToolTip(this.Cbo_avance_max, "Combobox para seleccionar el avance maximo \n" +
                                                     "del subobjetivo");

            toolTip1.SetToolTip(this.Cbo_avance_max, "Combobox para seleccionar el avance minimo \n" +
                                                     "del subobjetivo");

            toolTip1.SetToolTip(this.Cbo_objetivos, "Combobox para seleccionar el objetivo deseado");

            toolTip1.SetToolTip(this.Cbo_seleccion_proyecto, "Combobox para seleccionar el proyecto \n" +
                                                             "deseado");

            toolTip1.SetToolTip(this.Btn_cargar, "Muestra los subobjetivos dependiendo los datos \n" +
                                                 "introducidos en el filtro ");

        }
        private void FiltroSubobjetivos_Load(object sender, EventArgs e) 
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             *
             * Descripcion: Cargando proyectos al combobox para seleccionar proyecto
             * ...
             */

            // Agregar los tooltips y tabindex

            CargarToolTips();

            reportesSubobjetivos.ObtenerProyectos(Cbo_seleccion_proyecto);
            reportesSubobjetivos.ObtenerAuditores(Cbo_auditores);

            Cbo_auditores.Items.Add("Todos");
        } 
        private void Cbo_seleccion_proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             *
             * Descripcion: Cargando dominios a la lista de dominios
             * ...
             */

            Lst_dominios.Items.Clear();
            Lst_seleccion_dominios.Items.Clear();
            reportesSubobjetivos.ObtenerDominiosNormativa(Cbo_seleccion_proyecto, Lst_dominios);
        }
        private void Btn_mover_derecha_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: mueve un dominio a la lista de seleccion de dominios
             * 
             */

            if (Lst_dominios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar item");
            }
            else
            {

                string itemSeleccionado = (string)Lst_dominios.SelectedItem;
                Lst_seleccion_dominios.Items.Add(itemSeleccionado);
                Lst_dominios.Items.Remove(itemSeleccionado);
            }
        }
        private void Btn_mover_todos_derecha_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: mueve todos los dominios a la lista de seleccion de dominios
             * 
             */

            for (int j = 0; j <= Lst_dominios.Items.Count - 1; j++)
            {
                Lst_seleccion_dominios.Items.Add(Lst_dominios.Items[j]);
            }
            Lst_dominios.Items.Clear();
        }
        private void Btn_mover_izquierda_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: mueve un dominio a la lista de dominios
             * 
             */

            if (Lst_seleccion_dominios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar item");
            }
            else
            {
                string itemSeleccionado = (string)Lst_seleccion_dominios.SelectedItem;
                Lst_dominios.Items.Add(itemSeleccionado);
            }
        }
        private void Btn_mover_todos_izquierda_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             * 
             * Descripcion: mueve todos los dominios a la lista de dominios
             * 
             */

            for (int j = 0; j <= Lst_seleccion_dominios.Items.Count - 1; j++)
            {
                Lst_dominios.Items.Add(Lst_seleccion_dominios.Items[j]);
            }
            Lst_seleccion_dominios.Items.Clear();
        }
        private void Cbo_objetivos_DropDown(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             *
             * Descripcion: Cargando los objetivos segun los dominios seleccionados
             * ...
             */

            Cbo_objetivos.Items.Clear();
            Cbo_objetivos.Text = "";
            reportesSubobjetivos.ObtenerObjetivos(Cbo_objetivos, Lst_seleccion_dominios);


           
        }
        private void Btn_cargar_Click(object sender, EventArgs e)
        {
            /* Autor: Victor Fernandez
             * Fecha: 2/11/2019
             *
             * Descripcion: Muestra los subobjetiso del objetivo seleccionado
             * ...
             */
            reportesSubobjetivos.CargarDatos(Dgv_subobjetivos, Cbo_objetivos, Cbo_auditores, Cbo_avance_min, Cbo_avance_max);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            int filas = Dgv_subobjetivos.Rows.Count;

            for (int i = 0; i < filas; i++)
            {
                ds.Tables[0].Rows.Add
                (new object[] { Dgv_subobjetivos[0,i].Value.ToString(),
                Dgv_subobjetivos[1,i].Value.ToString(),
                Dgv_subobjetivos[2,i].Value.ToString(),

                }) ;
            }

            Reporte vista = new Reporte(ds, Cbo_objetivos.GetItemText(Cbo_objetivos.SelectedItem), Cbo_seleccion_proyecto.GetItemText(Cbo_seleccion_proyecto.SelectedItem));
            vista.ShowDialog();
        }
    }
}
