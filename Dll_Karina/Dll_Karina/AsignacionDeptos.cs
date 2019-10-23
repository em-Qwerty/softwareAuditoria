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
    public partial class AsignacionDeptos : Form
    {
        ventana ven = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        public AsignacionDeptos()
        {
            ven.pubSetName("Asignacion departamentos a proyecto");
            InitializeComponent();
            nav.LlenarTabla("tbl_asignaciondeptoaproyectos", dsn, Dgv_asignacion);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);

            nav.DatosCMB("tbl_proyecto", Cmb_proyecto, "nombre_Proyecto", "PK_Id_proyecto");
            nav.DatosCMB("tbl_departamentos", Cmb_depto, "nombre_dep", "PK_Id_departamentos");


            modificaarDataGrid();
            Dgv_asignacion.Columns[0].HeaderText = "Código Asignación";
            Dgv_asignacion.Columns[1].HeaderText = "Observación";
            Dgv_asignacion.Columns[2].HeaderText = "Id Proyecto";
            Dgv_asignacion.Columns[3].HeaderText = "Id Departamento";


        }


        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dgv_asignacion.Columns.Count; i++)
            {
                Dgv_asignacion.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_asignacion.Columns[i].ReadOnly = true;

            }
        }


        private void Cmb_proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_proyecto, Txt_codProyecto);
        }

        private void Cmb_proyecto_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_proyecto from tbl_proyecto where PK_Id_proyecto=", Cmb_proyecto, Txt_codProyecto);
        }

        private void Cmb_depto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_departamentos from tbl_departamentos where PK_Id_departamentos=", Cmb_depto, Txt_codDepto);
        }

        private void Cmb_depto_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select PK_Id_departamentos from tbl_departamentos where PK_Id_departamentos=", Cmb_depto, Txt_codDepto);
        }

        private void Lbl_codAsignacion_Click(object sender, EventArgs e)
        {

        }

        private void Txt_codAsignacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_nombreProyecto_Click(object sender, EventArgs e)
        {

        }

        private void Txt_codProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_codDepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_nombreDepto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_observacion_Click(object sender, EventArgs e)
        {

        }

        private void Txt_observacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
