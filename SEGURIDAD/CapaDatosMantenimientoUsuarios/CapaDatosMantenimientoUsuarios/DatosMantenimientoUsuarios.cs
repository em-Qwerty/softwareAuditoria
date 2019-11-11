using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatosMantenimientoUsuarios
{
    public class DatosMantenimientoUsuarios
    {
        public void InsertarDatosDeUsuarios(string nickname, string password)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO tbl_usuarios(usu_nickname, usu_password, estatus) VALUES('" + nickname + "','" + password + "',0)";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ModificarDatosDeUsuarios(string usuarioActual, string usuarioNuevo, string password, string estado)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_usuarios SET usu_nickname = '" + usuarioNuevo + "', usu_password = '" + password + "', estatus = "+estado+" WHERE usu_nickname = '" + usuarioActual + "';";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public DataSet ConsultarDatosDeUsuarios()
        {
            DataSet ds= new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_Usu_codigo as Codigo, usu_nickname as Nombre, estatus as Estado FROM tbl_usuarios";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public DataSet ConsultarDatosDeUsuarios1()
        {
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_Usu_codigo as Codigo, usu_nickname as Nombre, estatus as Estado FROM tbl_usuarios WHERE estatus = 0";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }

        public string[] cargarDatos1(string usuario)
        {
            string[] datos;
            datos = new string[3];
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT usu_nickname, usu_password, estatus FROM tbl_usuarios WHERE usu_nickname = '"+usuario+"'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["usu_nickname"].ToString());
                                datos[1] = (Reader["usu_password"].ToString());
                                datos[2] = (Reader["estatus"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return datos;
        }
        public void CambioDeContraseña(string usuarioActual, string usuarioNuevo, string password)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_usuarios SET usu_nickname = '" + usuarioNuevo + "', usu_password = '" + password + "' WHERE usu_nickname = '" + usuarioActual + "';";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
