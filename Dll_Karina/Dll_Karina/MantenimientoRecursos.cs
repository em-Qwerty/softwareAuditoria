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

namespace Dll_Karina
{
    public partial class MantenimientoRecursos : Form
    {
        ventana ven = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        public MantenimientoRecursos()
        {
            ven.pubSetName("Mantenimiento recursos TI");
            InitializeComponent();
            nav.LlenarTabla("tbl_recursosTI", dsn, Dgv_recursos);
        }

        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dgv_recursos.Columns.Count; i++)
            {
                Dgv_recursos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_recursos.Columns[i].ReadOnly = true;

            }
        }

    

        private void Cmb_tipo_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_TipoRecursoTI from tbl_TipoRecursoTI where PK_Id_TipoRecursoTI=",Cmb_tipo, Txt_codtipoRecurso);
        }

        private void Txt_codtipoRecurso_TextChanged(object sender, EventArgs e)
        {
            if (Txt_codtipoRecurso.Enabled == true)
            {
                Txt_codtipoRecurso.Enabled = false;
            }
            else
            {
                Txt_codtipoRecurso.Enabled = false;
            }
        }

        private void MantenimientoRecursos_Load(object sender, EventArgs e)
        {

        }

        private void ventana1_Load_1(object sender, EventArgs e)
        {
            nav.NombreForm(this);
            nav.DatosCMB("tbl_TipoRecursoTI", Cmb_tipo, "nombre_TipoRecursoTI", "PK_Id_TipoRecursoTI");

            modificaarDataGrid();
            Dgv_recursos.Columns[0].HeaderText = "Código Recurso";
            Dgv_recursos.Columns[1].HeaderText = "Nombre Recurso";
            Dgv_recursos.Columns[2].HeaderText = "Id Tipo";
        }

        private void Cmb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_TipoRecursoTI from tbl_TipoRecursoTI where PK_Id_TipoRecursoTI=", Cmb_tipo, Txt_codtipoRecurso);
        }
    }
}
