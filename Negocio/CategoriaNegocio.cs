using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Categoria> lista = new List<Categoria>();

            conexion.ConnectionString = "data source=.\\sqlexpress01; initial catalog= CATALOGO_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select id, Descripcion from Categorias";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while(lector.Read())
            {
                lista.Add(new Categoria((int)lector["id"], (string)lector["Descripcion"]));
            }

            lector.Close();
            conexion.Close();

            return lista;
        }
    }
}
