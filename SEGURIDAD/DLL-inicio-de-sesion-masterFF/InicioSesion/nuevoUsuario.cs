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
using CapaLogicaInicioSesion;


namespace InicioSesion
{
    public partial class nuevoUsuario : Form
    {
        public nuevoUsuario()
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
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private string encriptarContrasena(string contrasena)
        {
            string encriptado;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasena);
            encriptado = Convert.ToBase64String(encryted);
            return encriptado;
        }

        public string  desencriptarContrasena(string contrasena)
        {
            string encriptado;
            byte[] decryted = Convert.FromBase64String(contrasena);
            encriptado = System.Text.Encoding.Unicode.GetString(decryted);
            return encriptado;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = Txt_loginUser.Text;
            string contrasena = Txt_loginPass.Text;
            string confirmContrasena = Txt_confirmPass.Text;

            Logica lo = new Logica();

            bool exist = lo.existUser(usuario);
            if (exist == false)
            {
                if (contrasena == confirmContrasena)
                {
                    string encriptado = encriptarContrasena(contrasena);
                    lo.newUsuario(usuario, encriptado);
                    Console.WriteLine("Se ingreso con exito");
                    MessageBox.Show("Usuario Creado con exito");
                }
            }
            else
            {
                Console.WriteLine("Existe usuario");
                MessageBox.Show("Ya Existe el usuario","Alerta");
            }
            Txt_loginUser.Text = "";
            Txt_loginPass.Text = "";
            Txt_confirmPass.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
