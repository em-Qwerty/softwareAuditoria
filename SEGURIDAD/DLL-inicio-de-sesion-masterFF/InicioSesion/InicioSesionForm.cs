using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BIT;
using CapaLogicaInicioSesion;
using CapaDatosOpciones;
using CapaDiseñoOpciones;

namespace InicioSesion
{
    public partial class pnl_Menu : Form
    {
        graphicLayer bitcara = new graphicLayer();
        public pnl_Menu()
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
        private string encriptarContrasena(string contrasena)
        {
            string encriptado;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasena);
            encriptado = Convert.ToBase64String(encryted);
            return encriptado;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            nuevoUsuario nU = new nuevoUsuario();
            nU.ShowDialog();
        }

        private void InicioSesionForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string ruta = @"C:\Ayuda\ayuda.chm";
            Help.ShowHelp(this, ruta, "#Login");
        }

        private void Btn_loginAyuda_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Ayuda\ayuda.chm";
            Help.ShowHelp(this, ruta, "#Login");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void obtenerP(int usu, int app)
        {
            Logica l = new Logica();
            l.obtenerPermisos(usu, app);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_loginPass_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_loginUser_Click(object sender, EventArgs e)
        {

        }

        private void Txt_loginPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_loginUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string username = Txt_loginUser.Text;
            string password = Txt_loginPass.Text;

            Logica capaLogica = new Logica();

            if (username == "" || password == "")
            {
                MessageBox.Show("Los campos son obligatorios");

            }

            string pass = encriptarContrasena(password);
            if (capaLogica.login(username, pass))
            {
                this.Close();
                //MessageBox.Show("Usuario o contraseña correcta");
                Usuario user = new Usuario();
                String st = "Inicio de seión de usuario: " + user.obtenerUsuario();
                bitcara.Accion(st, "Inicio sesion");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pnl_Menu_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
    }
}
