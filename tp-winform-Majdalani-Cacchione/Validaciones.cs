using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace tp_winform_Majdalani_Cacchione
{
    public class Validaciones
    {
        public bool[] validacionesfrmAlta(string codigo, string nombre, string descripcion, string precio, int indexMarca, int indexCategoria)
        {
            bool[] validacion = new bool[6];
            //codigo
            if (validarStr(codigo))
                validacion[0] = true;
            //Nombre
            if (validarStr(nombre))
                validacion[1] = true;
            //Descripcion
            if (validarStr(descripcion))
                validacion[2] = true;
            //Precio
            if (validarPrecio(precio))
                validacion[3] = true;
            //Categoría
            if (validarCbobox(indexMarca))
                validacion[4] = true;
            //Marca
            if (validarCbobox(indexCategoria))
                validacion[5] = true;
            return validacion;
        }
        public bool validarStr(string cadena)
        {
            if(cadena.Length > 0)
                return true;
            return false;
        }

        public bool validarPrecio(string precio)
        {
            if (precio.Count(c => c == '.') > 1 || precio == "" || Decimal.Parse(precio) == 0)
                return false;
            return true;
        }
        public bool validarCbobox(int index)
        {
            if (index < 0)
                return false;
            return true;
        }

    }
}
