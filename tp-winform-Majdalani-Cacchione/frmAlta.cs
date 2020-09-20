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
            Validaciones val = new Validaciones();
            bool[] resultados = val.validacionesfrmAlta(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, cmbMarca.SelectedIndex, cmbCategoria.SelectedIndex);
            if (resultados[0] && resultados[1] && resultados[2] && resultados[3] && resultados[4] && resultados[5])
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
            {
                if (!resultados[0]) txtCodigo.BackColor = Color.Red;
                if (!resultados[1]) txtNombre.BackColor = Color.Red;
                if (!resultados[2]) txtDescripcion.BackColor = Color.Red;
                if (!resultados[3]) txtPrecio.BackColor = Color.Red;
                if (!resultados[4]) cmbMarca.BackColor = Color.Red;
                if (!resultados[5]) cmbCategoria.BackColor = Color.Red;
                MessageBox.Show("Campos incompletos", "Error de carga");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar != 46)
                    e.Handled = true;
            txtPrecio.BackColor = System.Drawing.Color.White;
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
            btnAgregarAlta.Text = "Agregar";
            if (articulo!= null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripción;
                txtImagen.Text = articulo.Imagen;
                txtNombre.Text = articulo.Nombre;
                txtPrecio.Text = articulo.Precio.ToString();
                cmbMarca.SelectedValue = articulo.Marca.ID;
                cmbCategoria.SelectedValue = articulo.Categoria.ID;
                Text = "Modificar Artículo";
                btnAgregarAlta.Text = "Modificar";
            }
      

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCodigo.BackColor = System.Drawing.Color.White;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre.BackColor = System.Drawing.Color.White;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDescripcion.BackColor = System.Drawing.Color.White;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarca.BackColor = System.Drawing.Color.White;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoria.BackColor = System.Drawing.Color.White;
        }
    }
}
