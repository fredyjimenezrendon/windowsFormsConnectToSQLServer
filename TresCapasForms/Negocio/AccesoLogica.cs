using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocio
{
    public class AccesoLogica
    {
        public int Insert(string nombre, string genero, int estrato, DateTime fecha, string desempleado)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Insert(nombre, genero, estrato, fecha, desempleado);
        }
    }
}
