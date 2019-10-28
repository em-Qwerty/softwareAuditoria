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
        public DataTable consultaLogica(string dato, string campo, string tabla)  //obtener datos de la consulta
        {
            Sentencia sn = new Sentencia();
            MySqlDataAdapter dt = sn.consultaBD(dato, campo, tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

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


        public void cargarDominios(object sender, EventArgs e, System.Windows.Forms.ComboBox cmbx)
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
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                string selectQuery = "SELECT Nombre FROM bdauditoria.tbl_dominio WHERE PK_Id_dominio <> 100000";
                connection.Open(); ;
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbx.Items.Add(reader.GetString("Nombre"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        







        }
    


    }
}
