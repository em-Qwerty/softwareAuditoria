using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CapaDatos;
using System.Data.Common;
using System.Reflection;
using System.Windows.Forms;
using System.Data.Odbc;

// Fill()




namespace CapaLogica
{
    public class Logica
    {
       
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }


        public void cargarDominios(object sender, EventArgs e, System.Windows.Forms.ComboBox cmbx, string consulta)
         {
            // 27/10/2019 Autor: Victor Fernandez
            // Esta funcion carga los dominios guardados en la base de datos al
            // combobox

            // string sql = "SELECT * FROM " + tabla + " WHERE " + campo + "='" + dato + "';"
            // like * where nombre = tbl_dominio





            /*string dato = "No hay";
            string campo = "Descripcion";
            string tabla = "tbl_dominio";

            try
            {

                Sentencia mi_sentencia = new Sentencia();
                MySqlDataAdapter da = mi_sentencia.consultaBD(dato, campo, tabla);



                DataSet ds = new DataSet();
                da.Fill(ds, tabla);

                cmbx.DataSource = da;
                cmbx.DisplayMember = tabla;

            }

            catch
            {
                MessageBox.Show("Error ocurred!");
            }*/
            /*DataTable dt = new DataTable("myTable");
            da.Fill(dt);

            List<String> datos_combo_box = new List<String>();
            datos_combo_box = ConvertDataTable<String>(dt);

            

            

            combo_a_llenar.DataSource = datos_combo_box;
            combo_a_llenar.DisplayMember = "Nombre";*/


            try
            {
                ConectarServidor cn = new ConectarServidor();
                string comando = consulta;

                OdbcCommand command = new OdbcCommand(comando, cn.Conexion()); 
                OdbcDataReader queryResultsReader = command.ExecuteReader();


                /*Sentencia miSentencia = new Sentencia();
                queryResultsReader = miSentencia.consultaBD(comando);*/

                while (queryResultsReader.Read())
                {
                  
                    cmbx.Items.Add(queryResultsReader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        







        }
    


    }
}
