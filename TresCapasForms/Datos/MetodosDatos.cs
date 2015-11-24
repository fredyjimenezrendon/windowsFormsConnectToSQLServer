using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class MetodosDatos
    {
        public static SqlCommand CrearComando()
        {
            string cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;
        }

        public static SqlCommand CrearComandoProc()
        {
            string cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand("insertar_encuesta", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }

        public static int EjecutarComandoInsert(SqlCommand comando)
        {      
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            //catch { throw; }
            catch (Exception ex)
            {
               throw ex;                
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        /*
        //devuelve un datatable con todos los registros que se encuentren en alguna tabla dada
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return _tabla;
        }
        */
    }
}
