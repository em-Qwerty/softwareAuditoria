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
    public partial class mantenimientoPerfilAplicacion : Form
    {
        Navegador navPA = new Navegador();
        DataSet mod;
        public mantenimientoPerfilAplicacion()
        {
            InitializeComponent();
            txtCodigoPerfil.Visible = false;
            txtCodigoApliacion.Visible = false;
            txtIngresar.Visible = false;
            txtEditar.Visible = false;
            txtGuardar.Visible = false;
            txtConsultar.Visible = false;
            txtBorrar.Visible = false;

            txtCodigo.Enabled = false;
            DataTable tabla = navPA.cargarDatos("tbl_perfil_detalle");
            dgAplicaciones.DataSource = tabla;
            navPA.nombreForm(this);
            navPA.setDataGR(dgAplicaciones);

            mod = navPA.cargarCombobox("tbl_perfil_encabezado", "PK_perf_cod_encabezado", "perf_nombre", "estatus");
            DataTable dtA = mod.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("PK_perf_cod_encabezado", typeof(string));
            dtA2.Columns.Add("perf_nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_perf_cod_encabezado"]);
                string marcA = Convert.ToString(row["perf_nombre"]);
                if (estA == "0")
                {
                    dtA2.Rows.Add(codA, marcA);
                }
            }
            cboModulo.DisplayMember = "perf_nombre";
            cboModulo.ValueMember = "PK_perf_cod_encabezado";
            cboModulo.DataSource = dsA.Tables[0];


            mod = navPA.cargarCombobox("tbl_aplicacion", "PK_Api_codigo", "api_descripcion", "estatus");
            DataTable dtA3 = mod.Tables[0];

            DataSet dsA2 = new DataSet();
            DataTable dtA4 = new DataTable();
            dsA2.Tables.Add(dtA4);
            dtA4.Columns.Add("PK_Api_codigo", typeof(string));
            dtA4.Columns.Add("api_descripcion", typeof(string));
            foreach (DataRow row in dtA3.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_Api_codigo"]);
                string marcA = Convert.ToString(row["api_descripcion"]);
                if (estA == "0")
                {
                    dtA4.Rows.Add(codA, marcA);
                }
            }
            comboBox1.DisplayMember = "api_descripcion";
            comboBox1.ValueMember = "PK_Api_codigo";
            comboBox1.DataSource = dsA2.Tables[0];

        }

        private string obtenerId()
        {
            string sParametro = "SELECT MAX(PK_correlativo) FROM tbl_perfil_detalle;";
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            OdbcCommand comando = new OdbcCommand(sParametro, conectar);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            string id = "";
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla);
                id = tabla.Tables[0].Rows[0]["MAX(PK_correlativo)"].ToString();
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

        private void MantenimientoPerfilAplicacion_Load(object sender, EventArgs e)
        {
            navPA.ingresarTabla("tbl_perfil_detalle");

            dgAplicaciones.Columns[0].HeaderText = "Codigo";
            dgAplicaciones.Columns[1].HeaderText = "Codigo Perfil";
            dgAplicaciones.Columns[2].HeaderText = "Codigo Aplicacion";
            dgAplicaciones.Columns[3].HeaderText = "Ingresar";
            dgAplicaciones.Columns[4].HeaderText = "Editar";
            dgAplicaciones.Columns[5].HeaderText = "Guardar";
            dgAplicaciones.Columns[6].HeaderText = "Borrar";
            dgAplicaciones.Columns[7].HeaderText = "Consultar";

            dgAplicaciones.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAplicaciones.ColumnHeadersDefaultCellStyle.Font = new Font(dgAplicaciones.Font, FontStyle.Bold);

            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txtCodigo.Text = codigoamb;
        }

        private void CboModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboModulo.SelectedValue.ToString());
            txtCodigoPerfil.Text = id.ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboModulo.SelectedValue.ToString());
            txtCodigoApliacion.Text = id.ToString();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtIngresar.Text = "1";
            }
            else
            {
                txtIngresar.Text = "0";
            }
        }

        private void CheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtEditar.Text = "1";
            }
            else
            {
                txtEditar.Text = "0";
            }
        }

        private void CheckBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                txtGuardar.Text = "1";
            }
            else
            {
                txtGuardar.Text = "0";
            }
        }

        private void CheckBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtBorrar.Text = "1";
            }
            else
            {
                txtBorrar.Text = "0";
            }
        }

        private void CheckBox5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                txtConsultar.Text = "1";
            }
            else
            {
                txtConsultar.Text = "0";
            }
        }

        private void DgAplicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            navPA.dgv_datos(dgAplicaciones);
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
    }
}
