using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace tp_winform_Majdalani_Cacchione
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            art.Nombre = txtNombre.Text;
            art.Imagen = txtImagen.Text;
            art.Descripción = txtDescripcion.Text;
            //art.Precio = (SqlMoney)txtPrecio.Text;
            art.Codigo = txtCodigo.Text;
            
            negocio.agregar(art);
        }
    }
}
