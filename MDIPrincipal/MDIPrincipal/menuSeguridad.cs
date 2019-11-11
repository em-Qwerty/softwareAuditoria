using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioSesion;
using mantenimientosSeguridad;
using CapaInterfazMantenimientoUsuarios;
using CapaInterfazIngresoModulos;
using System.Runtime.InteropServices;
using CapaInterfazAsignacionDePerfiles;

namespace MDISeguridad
{
    public partial class menuSeguridad : Form
    {
        int flag = 0;
        public menuSeguridad()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void MenuSeguridad_Load(object sender, EventArgs e)
        {
            /*
            pnl_Menu inicioSes = new pnl_Menu();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();
            */
            panelButton1.Hide();
            panel4.Hide();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Usuario u = new Usuario();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 295)
            {
                menuVertical.Width = 85;
                btn_Menu.Location = new Point(25,10);
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                panelButton1.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                menuVertical.Width = 295;
                btn_Menu.Location = new Point(244, 10);
                button2.Text = "USUARIOS";
                button3.Text = "PERFILES";
                button4.Text = "MODULOS";
                button5.Text = "APLICACIONES";
                button6.Text = "SALIR";
            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            mantenimientoAplicaciones ma = new mantenimientoAplicaciones();
            ma.TopLevel = false;
            ma.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(ma);
            ma.Show();
            ma.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void showPanel(Panel panel)
        {
            if(panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showPanel(panelButton1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Interfaz_Mostrar_Usuarios man = new Interfaz_Mostrar_Usuarios(panel3);
            if (flag == 1)
            {
                man.Close();
                this.panel3.Controls.Clear();
                this.panel3.Controls.Remove(man);
                flag--;
                Console.WriteLine(flag);
            }
            else
            {
                man.TopLevel = false;
                man.AutoScroll = true;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(man);
                man.Show();
                man.Dock = System.Windows.Forms.DockStyle.Fill;
                flag++;
                Console.WriteLine(flag);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InterfazAsignacionDePerfiles ma = new InterfazAsignacionDePerfiles();
            ma.TopLevel = false;
            ma.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(ma);
            ma.Show();
            ma.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InterfazIngresoModulos man = new InterfazIngresoModulos();
            man.TopLevel = false;
            man.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(man);
            man.Show();
            man.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            showPanel(panel4);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InterfazAsignacionDePerfiles ma = new InterfazAsignacionDePerfiles();
            ma.TopLevel = false;
            ma.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(ma);
            ma.Show();
            ma.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            mantenimientoPerfiles ma = new mantenimientoPerfiles();
            ma.TopLevel = false;
            ma.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(ma);
            ma.Show();
            ma.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            mantenimientoPerfilAplicacion ma = new mantenimientoPerfilAplicacion();
            ma.TopLevel = false;
            ma.AutoScroll = true;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(ma);
            ma.Show();
            ma.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
