using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Articulo()
        {
            this.Categoria = new Categoria();
            this.Marca = new Marca();
        }
        public int ID { get; set; }
        public string Descripción { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public decimal Precio { get; set; }
    }
}
