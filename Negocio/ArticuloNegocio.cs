﻿using System;
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
            comando.CommandText = "select a.Id, a.Codigo, a.Nombre, a.Descripcion ArtDescripcion, m.Descripcion MarDescripcion, c.Descripcion CatDescripcion, a.ImagenUrl, a.Precio from ARTICULOS as a, MARCAS as m, CATEGORIAS as c where m.Id = a.IdMarca and c.Id = a.IdCategoria";
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
                aux.Precio = (decimal)lector["Precio"];
                aux.Codigo = (string)lector["Codigo"];
                aux.ID = (int)lector["Id"];
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
            comando.CommandText = "insert into Articulos (Codigo, Nombre, Descripcion, idMarca, idcategoria, ImagenUrl, Precio) values('"+articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripción + "',@idMarca, @idCategoria, '" + articulo.Imagen + "','" + articulo.Precio + "')";
            comando.Parameters.AddWithValue("@idMarca", articulo.Marca.ID);
            comando.Parameters.AddWithValue("@idCategoria", articulo.Categoria.ID);

            comando.Connection = conexion;
            
            conexion.Open();
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
