using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador_;
using ventanaDiseno;


namespace Dll_Karina
{
    public partial class MantenimientoRecursosTI : Form
    {
        DisenoNavegador nav = new DisenoNavegador();
        ventana ven = new ventana();
        string dsn = "dsnAuditoria";

        public MantenimientoRecursosTI()
        {
            ven.pubSetName("Ingreso Recursos TI");
            InitializeComponent();
            nav.LlenarTabla("tbl_recursosTI", dsn, Dgv_asignacion);
        }

        private void MantenimientoRecursosTI_Load(object sender, EventArgs e)
        {

        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);

            nav.DatosCMB("tbl_tipoRecursoTI", Cmb_tipo, "nombre_TipoRecursoTI", "PK_Id_TipoRecursoTI");

            modificaarDataGrid();
            Dgv_asignacion.Columns[0].HeaderText = "Código Recurso";
            Dgv_asignacion.Columns[1].HeaderText = "Nombre Recurso";
            Dgv_asignacion.Columns[2].HeaderText = "Id Tipo";

        }


        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dgv_asignacion.Columns.Count; i++)
            {
                Dgv_asignacion.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_asignacion.Columns[i].ReadOnly = true;

            }
        }

        private void Cmb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_TipoRecursoTI from tbl_tipoRecursoTI where PK_Id_TipoRecursoTI=", Cmb_tipo, Txt_codtipoRecurso);
        }
    }
}
