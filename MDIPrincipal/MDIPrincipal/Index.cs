/* AUTOR: JULIO SICAJA */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemploVentana;
using InicioSesion;
using Abner_Portillo;
using Mantenimientos_EP;
using Dll_Karina;

namespace MDIPrincipal
{
    public partial class Index : Form
    {
        private void priChildMDI(Form fmr)
        {
            try
            {
                if (Application.OpenForms[fmr.Name] != null)
                {
                    Application.OpenForms[fmr.Name].Activate();
                }
                else
                {
                    fmr.MdiParent = this;
                    fmr.StartPosition = FormStartPosition.CenterScreen;
                    fmr.Show();
                }
            }
            catch (Exception)
            {

            }
           
        }
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Location = new Point(0, 0);  //sobra si tienes la posición en el diseño
            Form fmr_logo = new logo();
            fmr_logo.MdiParent = this;
            fmr_logo.StartPosition = FormStartPosition.CenterScreen;
            fmr_logo.Enabled = false;
            fmr_logo.Show();

            pnl_Menu inicioSes = new pnl_Menu();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;                
                }
                catch (InvalidCastException exc)
                {

                }
            }
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Usuario u = new Usuario();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnl_Menu inicioSes = new pnl_Menu();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Form1());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MundoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new MDISeguridad.menuSeguridad());
        }

        private void DominioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Abner_Portillo.Frm_dominio());
        }

        private void MantenimientoAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //priChildMDI(new moduloKarla.mantenimientosAnalisis());
        }

        private void MantenimientoAuditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //priChildMDI(new moduloKarla.mantenimientoAuditores());
        }

        private void ObjetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Abner_Portillo.Frm_objetivo());
        }

        private void NormativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Abner_Portillo.Frm_normativa());
        }

        private void MantenimientoDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Mantenimientos_EP.mantenimiento_Departamento());
        }

        private void ProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Mantenimientos_EP.mantenimiento_Proyectos());
        }

        private void MantenimientoRecursoDeTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new Dll_Karina.MantenimientoRecursosTI());
        }

        private void mantenimientoAsignaciónAuditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new mantenimientos_SB.mantenimiento_asignacionAuditorProyecto());
        }

        private void mantenimientoAsignaciónRecursosDeTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priChildMDI(new mantenimientos_SB.mantenimiento_asignacionRecursosTI());
        }
    }
}
