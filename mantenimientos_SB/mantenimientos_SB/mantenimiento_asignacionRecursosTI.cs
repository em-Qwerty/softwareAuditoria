using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventanaDiseno;
using Navegador_;


namespace mantenimientos_SB
{
    public partial class mantenimiento_asignacionRecursosTI : Form
    {
        ventana ventana = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        public mantenimiento_asignacionRecursosTI()
        {
            ventana.pubSetName("Asignación Recursos TI");
            InitializeComponent();
            nav.LlenarTabla("tbl_asignacionrecursosti", dsn, Dtg_datos);
        }
        private static mantenimiento_asignacionRecursosTI mFormDefInstance = null;
        public static mantenimiento_asignacionRecursosTI DefInstance
        {
            get
            {
                if (mFormDefInstance == null || mFormDefInstance.IsDisposed)
                    mFormDefInstance = new mantenimiento_asignacionRecursosTI();
                return mFormDefInstance;
            }
            set
            {
                mFormDefInstance = value;
            }
        }

        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dtg_datos.Columns.Count; i++)
            {
                Dtg_datos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dtg_datos.Columns[i].ReadOnly = true;

            }
        }


        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);
            nav.DatosCMB("tbl_proyecto", Cmb_Proyecto, "nombre_Proyecto", "PK_Id_proyecto");
            nav.DatosCMB("tbl_rubricaEncabezado", Cmb_Rubrica, "Documento_rubrica", "PK_Codrubricae");
            nav.DatosCMB("tbl_recursosTI", Cmb_tipoRecurso, "nombre_Recurso", "Pk_Id_RecursoTi");



            modificaarDataGrid();
            Dtg_datos.Columns[0].HeaderText = "Código Recurso";            
            Dtg_datos.Columns[1].HeaderText = "Descripción";
            Dtg_datos.Columns[2].HeaderText = "Tipo Recurso";
            Dtg_datos.Columns[3].HeaderText = "Id Proyecto";
            Dtg_datos.Columns[4].HeaderText = "Id Rúbrica";
        }

        private void Lbl_TipoRecurso_Click(object sender, EventArgs e)
        {
            
        }

        private void Cmb_tipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select Pk_Id_RecursoTi from tbl_recursosTI where Pk_Id_RecursoTi=", Cmb_tipoRecurso, TxtRecurso);
        }

        private void Txt_nameRecurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_noProyecto_TextChanged(object sender, EventArgs e)
        {
            if (txt_noProyecto.Enabled == true)
            {
                txt_noProyecto.Enabled = false;
            }
            else
            {
                txt_noProyecto.Enabled = false;
            }
        }

        private void TxtRecurso_TextChanged(object sender, EventArgs e)
        {
            if (TxtRecurso.Enabled == true)
            {
                TxtRecurso.Enabled = false;
            }
            else
            {
                TxtRecurso.Enabled = false;
            }
        }

        private void Txt_Rubrica_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Rubrica.Enabled == true)
            {
                Txt_Rubrica.Enabled = false;
            }
            else
            {
                Txt_Rubrica.Enabled = false;
            }
        }

        private void Cmb_Proyecto_SelectedValueChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void Cmb_Proyecto_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void Cmb_tipoRecurso_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void Cmb_Rubrica_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Codrubricae from tbl_rubricaEncabezado where PK_Codrubricae=", Cmb_Rubrica, Txt_Rubrica);
        }

        private void Cmb_Rubrica_SelectedValueChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Codrubricae from tbl_rubricaEncabezado where PK_Codrubricae=", Cmb_Rubrica, Txt_Rubrica);
        }

        private void Cmb_Rubrica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
