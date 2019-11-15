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
using System.Data.Odbc;

namespace ClassLibrary1
{
    public partial class frmSubObjetivos : Form
    {
        OdbcConnection cn = new OdbcConnection("dsn=dsnAuditoria");
        ventana ven = new ventana();
        DisenoNavegador nav = new DisenoNavegador();
        String dsn = "dsnAuditoria";
        public frmSubObjetivos()
        {
            ven.pubSetName("Sub-Ojbetivos");
            InitializeComponent();
            
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.LlenarTabla("tbl_subobjetivo", dsn, Dgv_subobjetivos);
            nav.NombreForm(this);
            nav.DatosCMB("tbl_auditores", Cbo_auditores, "nombre", "correo");
            Btn_asignar.Enabled = true;
            Dgv_subobjetivos.Enabled = true;
        }

        private void Dgv_subobjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string subobjetivo;
            subobjetivo = Dgv_subobjetivos.CurrentCell.Value.ToString();
            Lbl_subobj.Text = subobjetivo;

            Cbo_auditores.Enabled = true;
        }

        private void Btn_asignar_Click(object sender, EventArgs e)
        {
            OdbcCommand consulta = new OdbcCommand("UPDATE tbl_subobjetivo SET tbl_auditores_Pk_carnet = (SELECT Pk_carnet FROM tbl_auditores where nombre LIKE '" + Cbo_auditores.Text + "') WHERE tbl_auditores_Pk_carnet = '0'");
            consulta.Connection = cn;

            try
            {
                cn.Open();
                consulta.ExecuteNonQuery();

                Cbo_auditores.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
