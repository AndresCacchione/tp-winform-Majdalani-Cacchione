using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            conexion.ConnectionString = "data source= ANDRES-PC\\SQLEXPRESS01; initial catalog=CATALOGO_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select a.Id, a.Codigo, a.Nombre, a.Descripcion ArtDescripcion, m.Descripcion MarDescripcion, c.Descripcion CatDescripcion, a.ImagenUrl, a.Precio from ARTICULOS as a inner join MARCAS as m on m.Id = a.Id inner join CATEGORIAS as c on c.Id = a.Id";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Nombre = (string)lector["Nombre"];
                aux.Descripción = (string)lector["ArtDescripcion"];
                aux.Imagen = (string)lector["ImagenUrl"];
                aux.Marca.Descripcion = (string)lector["MarDescripcion"];
                aux.Categoria.Descripcion = (string)lector["CatDescripcion"];
                lista.Add(aux);
            }

            lector.Close();
            conexion.Close();
            return lista;
        }
        
        public void agregar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
       
            conexion.ConnectionString = "data source= ANDRES-PC\\SQLEXPRESS01; initial catalog=CATALOGO_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into Articulos (Nombre, Descripcion, ) values('','');
            comando.Connection = conexion;

            conexion.Open();
            //comando.ExecuteReader();


        }
    }
}
