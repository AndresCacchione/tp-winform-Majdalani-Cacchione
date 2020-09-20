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
        private Articulo articulo = null;
        public frmAlta()
        {
            InitializeComponent();
        }
        public frmAlta(Articulo Art)
        {
            InitializeComponent();
            articulo = Art;
            
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {

            if (articulo == null)
                articulo = new Articulo();
            
            if (cmbCategoria.SelectedIndex >= 0 && cmbMarca.SelectedIndex >= 0 && txtNombre.Text!="" && txtDescripcion.Text != "" && txtCodigo.Text!="" && txtPrecio.Text!="")
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                articulo.Nombre = txtNombre.Text;
                articulo.Imagen = txtImagen.Text;
                articulo.Descripción = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text); // Esto hay que ver si funka, el parse es un casteo
                articulo.Codigo = txtCodigo.Text;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;

                if (articulo.ID == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente!", "Exito");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!", "Exito");
                }
                Close();
            }

            else
                MessageBox.Show("Campos incompletos", "Error de carga");

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
            cmbCategoria.ValueMember = "ID";
            cmbCategoria.DisplayMember = "Descripcion";
            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Descripcion";
           
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;

            if(articulo!= null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripción;
                txtImagen.Text = articulo.Imagen;
                txtNombre.Text = articulo.Nombre;
                txtPrecio.Text = articulo.Precio.ToString();
                cmbMarca.SelectedValue = articulo.Marca.ID;
                cmbCategoria.SelectedValue = articulo.Categoria.ID;
                Text = "Modificar Artículo";
            }
      

        }
         

    }
}
