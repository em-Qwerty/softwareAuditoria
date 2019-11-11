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
    public partial class mantenimientoAplicaciones : Form
    {
        Navegador nvAplicacion = new Navegador();
        DataSet mod;
        public mantenimientoAplicaciones()
        {
            InitializeComponent();
            txtCodigoModulo.Visible = false;
            txtCodigo.Enabled = false;
            DataTable tabla = nvAplicacion.cargarDatos("tbl_aplicacion");
            dgAplicaciones.DataSource = tabla;
            nvAplicacion.nombreForm(this);
            nvAplicacion.setDataGR(dgAplicaciones);

            mod = nvAplicacion.cargarCombobox("tbl_modulos", "PK_Modulo_codigo", "modulo_nombre", "estatus");
            DataTable dtA = mod.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("PK_Modulo_codigo", typeof(string));
            dtA2.Columns.Add("modulo_nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_Modulo_codigo"]);
                string marcA = Convert.ToString(row["modulo_nombre"]);
                if (estA == "0")
                {
                    dtA2.Rows.Add(codA, marcA);
                }
            }
            cboModulo.DisplayMember = "modulo_nombre";
            cboModulo.ValueMember = "PK_Modulo_codigo";
            cboModulo.DataSource = dsA.Tables[0];
        }

        private string obtenerId()
        {
            string sParametro = "SELECT MAX(PK_Api_codigo) FROM tbl_aplicacion;";
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            OdbcCommand comando = new OdbcCommand(sParametro, conectar);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            string id = "";
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla);
                id = tabla.Tables[0].Rows[0]["MAX(PK_Api_codigo)"].ToString();
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

        private void MantenimientoAplicaciones_Load(object sender, EventArgs e)
        {
            nvAplicacion.ingresarTabla("tbl_aplicacion");

            dgAplicaciones.Columns[0].HeaderText = "Codigo";
            dgAplicaciones.Columns[1].HeaderText = "Descripcion";
            dgAplicaciones.Columns[2].HeaderText = "Codigo Modulo";
            dgAplicaciones.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.ColumnHeadersDefaultCellStyle.Font = new Font(dgAplicaciones.Font, FontStyle.Bold);

            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txtCodigo.Text = codigoamb;
        }


        private void CboModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboModulo.SelectedValue.ToString());
            txtCodigoModulo.Text = id.ToString();
        }

        private void TxtCodigoModulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgAplicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAplicacion.dgv_datos(dgAplicaciones);
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

        private void DgAplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
