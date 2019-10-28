using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaDiseno
{
    public partial class GraficasAvance : UserControl
    {
        public GraficasAvance()
        {
            InitializeComponent();
        }

        private void GraficasAvance_Load(object sender, EventArgs e)
        {
            Logica logica = new Logica();
            logica.cargarDominios(this, e, Cbo_dominios, "SELECT Nombre FROM bdauditoria.tbl_dominio WHERE PK_Id_dominio <> 10000");
        }

        private void Cbo_dominios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
