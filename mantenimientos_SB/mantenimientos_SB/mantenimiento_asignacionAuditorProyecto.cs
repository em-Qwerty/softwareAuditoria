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
    public partial class mantenimiento_asignacionAuditorProyecto : Form
    {
        ventana ventana = new ventana();        
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        
        public mantenimiento_asignacionAuditorProyecto()
        {

            ventana.pubSetName("Asignación Auditores a Proyecto");
            InitializeComponent();
            nav.LlenarTabla("tbl_asignacionauditoresaproyecto",dsn, Dtg_datos);
            

        }

        private static mantenimiento_asignacionAuditorProyecto mFormDefInstance = null;
        public static mantenimiento_asignacionAuditorProyecto DefInstance
        {
            get
            {
                if (mFormDefInstance == null || mFormDefInstance.IsDisposed)
                    mFormDefInstance = new mantenimiento_asignacionAuditorProyecto();
                return mFormDefInstance;
            }
            set
            {
                mFormDefInstance = value;
            }
        }

        private void Lbl_NameAuditor_Click(object sender, EventArgs e)
        {

        }

        private void MAP_Load(object sender, EventArgs e)
        {
            

        }

         

        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dtg_datos.Columns.Count; i++)
            {
                Dtg_datos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dtg_datos.Columns[i].ReadOnly = true;

            }
        }

        private void Cmb_Proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void mantenimiento_asignacionAuditorProyecto_Load(object sender, EventArgs e)
        {
           

        }

        private void mantenimiento_asignacionAuditorProyecto_Load_1(object sender, EventArgs e)
        {
           
        }

 
        private void Cmb_Proyecto_SelectedValueChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void Cmb_Proyecto_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_Proyecto, txt_noProyecto);
        }

        private void Cmb_Auditor_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select Pk_carnet from tbl_auditores where Pk_carnet=", Cmb_Auditor, Txt_auditor);
        }

        private void Cmb_Auditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select Pk_carnet from tbl_auditores where Pk_carnet=", Cmb_Auditor, Txt_auditor);
        }

        private void ventana1_Load_2(object sender, EventArgs e)
        {
            nav.NombreForm(this);
            nav.DatosCMB("tbl_proyecto", Cmb_Proyecto, "nombre_Proyecto", "PK_Id_proyecto");
            nav.DatosCMB("tbl_auditores", Cmb_Auditor, "nombre", "Pk_carnet");



            modificaarDataGrid();
            Dtg_datos.Columns[0].HeaderText = "Código Asignación";
            Dtg_datos.Columns[1].HeaderText = "Observación";
            Dtg_datos.Columns[2].HeaderText = "Código Proyecto";
            Dtg_datos.Columns[3].HeaderText = "Código Auditor";
        }

        private void disenoNavegador1_Load(object sender, EventArgs e)
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

        private void Txt_auditor_TextChanged(object sender, EventArgs e)
        {
            if (Txt_auditor.Enabled == true)
            {
                Txt_auditor.Enabled = false;
            }
            else
            {
                Txt_auditor.Enabled = false;
            }
        }
    }
}
