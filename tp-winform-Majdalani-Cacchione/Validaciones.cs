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
        public bool[] validacionesfrmAlta(string codigo, string nombre, string descripcion, string precio, int indexMarca, int indexCategoria, string imagen)
        {
            bool[] validacion = new bool[7];
            //codigo
            if (validarStr(codigo, 50))
                validacion[0] = true;
            //Nombre
            if (validarStr(nombre, 50))
                validacion[1] = true;
            //Descripcion
            if (validarStr(descripcion, 150))
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
            //Imagen
            if (validarStrOptativo(imagen, 1000))
                validacion[6] = true;
            return validacion;
        }
        public bool validarStr(string cadena, int maxlength)
        {
            if((cadena.Length > 0) && (cadena.Length < maxlength))
                return true;
            return false;
        }

        public bool validarStrOptativo(string cadena, int maxlength)
        {
            if (cadena.Length < maxlength)
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
