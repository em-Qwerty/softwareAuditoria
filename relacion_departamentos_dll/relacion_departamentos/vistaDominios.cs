using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_logica_relacion_departamentos;

namespace relacion_departamentos
{
    public partial class vistaDominios : Form
    {
        LogicaRelacionDepto logicLayer = new LogicaRelacionDepto();

        public vistaDominios()
        {
            InitializeComponent();
        }

        void cargarDominios()
        {
            dgDominios.DataSource = logicLayer.obtenerDominios();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dgDominios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //OBTIENE INDICE DE LA FILA 
            DataGridViewRow row = dgDominios.Rows[e.RowIndex];

            String idSeleccionado = row.Cells[0].Value.ToString();

            vistaObjetivos viewObj = new vistaObjetivos(idSeleccionado);
            this.Hide();
            viewObj.Show();
        }

        private void vistaDominios_Load(object sender, EventArgs e)
        {
            cargarDominios();

        }
    }
}
