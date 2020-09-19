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
            art.Precio = decimal.Parse(txtPrecio.Text); // Esto hay que ver si funka, el parse es un casteo
            art.Codigo = txtCodigo.Text;
            art.Marca = (Marca)cmbMarca.SelectedItem;
            art.Categoria = (Categoria)cmbCategoria.SelectedItem;

            negocio.agregar(art);
            MessageBox.Show("Cargado exitosamente!", "Exito");
            Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar != 46)
                    e.Handled = true;
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cmbCategoria.DataSource = categoriaNegocio.listar();
            cmbMarca.DataSource = marcaNegocio.listar();
            
        }
    }
}
