using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoNavegador;
using ventanaDiseno;

namespace mantenimientos_AsignaciónAuditores
{
    public partial class Mantenimientos_Asignacion : Form
    {

        Navegador nvAplicacion = new Navegador();
        ventana ven = new ventana();
        public Mantenimientos_Asignacion()
        {
            ven.pubSetName("Asignación auditores");
            InitializeComponent();
        }

        private void ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
