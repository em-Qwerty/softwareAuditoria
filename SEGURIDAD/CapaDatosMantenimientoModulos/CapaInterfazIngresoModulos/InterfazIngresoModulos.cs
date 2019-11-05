using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaDiNavegador;               // LLamada a capa del navegador   
using System.Data.Odbc;

namespace CapaInterfazIngresoModulos
{
    public partial class InterfazIngresoModulos : Form
    {
        Navegador nv = new Navegador();
        public InterfazIngresoModulos()
        {
            InitializeComponent();
            txt_Codigo.Enabled = false;
            DataTable tabla = nv.cargarDatos("tbl_modulos");
            dataGridView1.DataSource = tabla;
            nv.nombreForm(this);
            nv.setDataGR(dataGridView1);
        }

        private string obtenerId()
        {
            string sParametro = "SELECT MAX(PK_Modulo_codigo) FROM tbl_modulos;";
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            OdbcCommand comando = new OdbcCommand(sParametro, conectar);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            string id = "";
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla);
                id = tabla.Tables[0].Rows[0]["MAX(PK_Modulo_codigo)"].ToString();
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

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InterfazIngresoModulos_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_modulos");

            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Nombre Modulo";
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txt_Codigo.Text = codigoamb;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nv.dgv_datos(dataGridView1);
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txt_Codigo.Enabled = false;
            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txt_Codigo.Text = codigoamb;
        }

        private void Txt_Codigo_EnabledChanged(object sender, EventArgs e)
        {
            txt_Codigo.Enabled = false;
            int id = Convert.ToInt32(obtenerId()) + 1;
            string codigoamb = id.ToString();
            txt_Codigo.Text = codigoamb;
        }
    }
}
