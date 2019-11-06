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
    public partial class vistaSubObjetivos : Form
    {

        LogicaRelacionDepto logicLayer = new LogicaRelacionDepto();

        //Variables de control
        String _idObjetivo;
        String _idDominio;
        public vistaSubObjetivos(String idObjetivo, String idDominio)
        {
            InitializeComponent();
            _idObjetivo = idObjetivo;
            _idDominio = idDominio;
        }

        void cargarSubOjetivos()
        {
            dgSubObjetivos.DataSource = logicLayer.obtieneSubObjetivos(_idObjetivo);
        }
        private void vistaSubObjetivos_Load(object sender, EventArgs e)
        {
            cargarSubOjetivos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vistaObjetivos viewObjetivos = new vistaObjetivos(_idDominio);
            viewObjetivos.Show();
        }
    }
}
