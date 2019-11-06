using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using capa_datos_relacion_departamentos;


namespace capa_logica_relacion_departamentos
{
    public class LogicaRelacionDepto
    {

        DatosRelacionDepto conn = new DatosRelacionDepto();
        OdbcCommand cmd;
        OdbcDataReader dr;

        //OBTIENE DOMINIOS
        public DataTable obtenerDominios()
        {
            String query = "SELECT * FROM tbl_dominio";

            try
            {
                DataTable dt = new DataTable();

                cmd = new OdbcCommand(query, conn.Conectar());
                dr = cmd.ExecuteReader();

                //ENCABEZADO COLUMNAS
                dt.Columns.Add("ID");
                dt.Columns.Add("DOMINIO");


                while (dr.Read())
                {

                    DataRow row = dt.NewRow();
                    row["ID"] = dr["PK_Id_dominio"];
                    row["DOMINIO"] = dr["Nombre"];
                    dt.Rows.Add(row);


                }

                conn.Desconectar();
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;

        }

        //OBTIENE OBJETIVOS
        public DataTable obtenerObjetivos(String IdDominio)
        {

            String query = "SELECT objetivo.PK_Id_Objetivo as ID, objetivo.Nombre as OBJETIVO, auditor.nombre as RESPONSABLE FROM tbl_asignacionauditorobjetivo as asignacion" +
                           " INNER JOIN tbl_objetivo as objetivo" +
                           " on asignacion.PK_FK_Id_Objetivo = objetivo.PK_Id_Objetivo" +
                           " INNER JOIN tbl_auditores as auditor" +
                           " on asignacion.Pk_FK_carnet = auditor.Pk_carnet" +
                           " WHERE objetivo.tbl_dominio_PK_Id_dominio = '" + IdDominio + "' ";

            try
            {
                DataTable dt = new DataTable();

                cmd = new OdbcCommand(query, conn.Conectar());
                dr = cmd.ExecuteReader();

                //ENCABEZADO COLUMNAS
                dt.Columns.Add("ID");
                dt.Columns.Add("OBJETIVO");
                dt.Columns.Add("RESPONSABLE");

                while (dr.Read())
                {

                    DataRow row = dt.NewRow();
                    row["ID"] = dr["ID"];
                    row["OBJETIVO"] = dr["OBJETIVO"];
                    row["RESPONSABLE"] = dr["RESPONSABLE"];
                    dt.Rows.Add(row);


                }

                conn.Desconectar();
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;

        }

        //OBTIENE SUBOJETIVOS
        public DataTable obtieneSubObjetivos(String idObjetivo)
        {
            String query = "SELECT subObj.PK_ID_Subobjetivo as ID, subObj.Nombre as Nombre FROM tbl_subobjetivo as subObj" +
                           " WHERE subObj.tbl_auditores_Pk_carnet =" +
                           " (SELECT auObj.Pk_FK_carnet as carneAuditor FROM tbl_asignacionauditorobjetivo as auObj" +
                           " WHERE auObj.PK_FK_Id_Objetivo =  '" + idObjetivo + "') ";

            try
            {
                DataTable dt = new DataTable();

                cmd = new OdbcCommand(query, conn.Conectar());
                dr = cmd.ExecuteReader();

                //ENCABEZADO COLUMNAS
                dt.Columns.Add("ID");
                dt.Columns.Add("SUBOBJETIVO");


                while (dr.Read())
                {

                    DataRow row = dt.NewRow();
                    row["ID"] = dr["ID"];
                    row["SUBOBJETIVO"] = dr["Nombre"];
                    dt.Rows.Add(row);


                }

                conn.Desconectar();
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;

        }
    }
}
