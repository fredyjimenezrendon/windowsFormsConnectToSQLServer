using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatos
    {
        public int Insert(string nombre, string genero, int estrato, DateTime fecha, string desempleado)
        {
            SqlCommand comando = MetodosDatos.CrearComandoProc();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@estrato", estrato);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@desempleado", desempleado);
            return MetodosDatos.EjecutarComandoInsert(comando);
        }
    }
}
