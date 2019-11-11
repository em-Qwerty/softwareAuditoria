using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiNavegador;

namespace mantenimientosSeguridad
{
    public partial class mantenimientoPerfiles : Form
    {
        Navegador nvPerfiles = new Navegador();
        public mantenimientoPerfiles()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            DataTable tabla = nvPerfiles.cargarDatos("tbl_perfil_encabezado");
            dgAplicaciones.DataSource = tabla;
            nvPerfiles.nombreForm(this);
            nvPerfiles.setDataGR(dgAplicaciones);
        }

        private string obtenerId()
        {
            string sParametro = "SELECT MAX(PK_perf_cod_encabezado) FROM tbl_perfil_encabezado;";
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            OdbcCommand comando = new OdbcCommand(sParametro, conectar);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            string id = "";
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla);
                id = tabla.Tables[0].Rows[0]["MAX(PK_perf_cod_encabezado)"].ToString();
                Console.WriteLine(id);
                if ((id == null) || (id == ""))
                {
                    id = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no existe ID");
                id = "0";
            }
            return id;
        }

        private void MantenimientoPerfiles_Load(object sender, EventArgs e)
        {
            nvPerfiles.ingresarTabla("tbl_perfil_encabezado");

            dgAplicaciones.Columns[0].HeaderText = "Codigo";
            dgAplicaciones.Columns[1].HeaderText = "Nombre Perfil";
            dgAplicaciones.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.ColumnHeadersDefaultCellStyle.Font = new Font(dgAplicaciones.Font, FontStyle.Bold);

            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txtCodigo.Text = codigoamb;
        }

        private void DgAplicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvPerfiles.dgv_datos(dgAplicaciones);
        }

        private void DgAplicaciones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtCodigo.Enabled = false;
            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txtCodigo.Text = codigoamb;
        }

        private void TxtCodigo_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txtCodigo.Text = codigoamb;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mantenimientoPerfilAplicacion mpa = new mantenimientoPerfilAplicacion();
            mpa.ShowDialog();
        }

        private void Btn_loginAyuda_Click(object sender, EventArgs e)
        {
            mantenimientoPerfilAplicacion mpa = new mantenimientoPerfilAplicacion();
            mpa.ShowDialog();
        }
    }
}
