using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesSubobjetivos
{
    public partial class Reporte : Form
    {
        public Reporte(DataSet ds, string objetivo, string proyecto)
        {
            InitializeComponent();

            ReporteSubobjetivos nuevoReporte = new ReporteSubobjetivos();

            //transefer data to crystalreportviewer
            //CrystalReport1 cr = new CrystalReport1();
            //cr.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = cr;

            
            nuevoReporte.SetDataSource(ds);


            try
            {
                nuevoReporte.SetParameterValue("objetivo", objetivo);
                nuevoReporte.SetParameterValue("proyecto", proyecto);

            } 

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            crystalReportViewer1.ReportSource = nuevoReporte; 

           






            //Reporte oRep = new Reporte();



        }
    }
}
