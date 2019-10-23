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
    public partial class MantenimientoDepartamentos : Form
    {
        ventana ven = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        public MantenimientoDepartamentos()
        {
            ven.pubSetName("Mantenimiento Departamentos");
            InitializeComponent();
            nav.LlenarTabla("tbl_departamentos", dsn, Dgv_deptos);
        }

        private void Txt_codRecurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);

            modificaarDataGrid();
            Dgv_deptos.Columns[0].HeaderText = "Código Departamento";
            Dgv_deptos.Columns[1].HeaderText = "Nombre Departamento";
            Dgv_deptos.Columns[2].HeaderText = "Descripción";
        }
        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dgv_deptos.Columns.Count; i++)
            {
                Dgv_deptos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_deptos.Columns[i].ReadOnly = true;

            }
        }
    }
}
