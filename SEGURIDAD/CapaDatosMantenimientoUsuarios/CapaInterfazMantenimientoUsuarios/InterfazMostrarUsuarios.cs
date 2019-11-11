using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoUsuarios;
using CapaInterfazMantenimientoUsuarios;
using System.IO;
using CapaDiNavegador;                       // LLamada a la capa del navegador

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class Interfaz_Mostrar_Usuarios : Form
    {
        Navegador nv = new Navegador();
        public Panel frm;
        public Interfaz_Mostrar_Usuarios(Panel frm2)
        {
            InitializeComponent();
            DataTable dt = nv.cargarDatos("tbl_usuarios");
            dataGridView1.DataSource = dt;
            nv.nombreForm(this);
            nv.setDataGR(dataGridView1);
            frm = frm2;
        }

        private void InterfazMostrarUsuarios_Load(object sender, EventArgs e)
        {
            nv.ingresarTabla("tbl_usuarios");

            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Usuario";
            dataGridView1.Columns[2].HeaderText = "Contraseña";
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Interfaz_Mostrar_Usuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this, rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nv.dgv_datos(dataGridView1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
