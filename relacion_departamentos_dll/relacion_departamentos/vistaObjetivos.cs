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
    public partial class vistaObjetivos : Form
    {


        LogicaRelacionDepto logicLayer = new LogicaRelacionDepto();
        String _idDominio;
        public vistaObjetivos(String idDominio)
        {
            InitializeComponent();
            _idDominio = idDominio;
        }



        void cargarObjetivos()
        {
            dgObjetivos.DataSource = logicLayer.obtenerObjetivos(_idDominio);
        }

        private void lbl_Encabezado_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vistaObjetivos_Load(object sender, EventArgs e)
        {
            cargarObjetivos();
        }

        private void dgObjetivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //OBTIENE INDICE DE LA FILA 
            DataGridViewRow row = dgObjetivos.Rows[e.RowIndex];

            String idSeleccionado = row.Cells[0].Value.ToString();

            vistaSubObjetivos viewSubObj = new vistaSubObjetivos(idSeleccionado, _idDominio);
            viewSubObj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vistaDominios viewGeneral = new vistaDominios();
            viewGeneral.Show();
        }
    }
}
