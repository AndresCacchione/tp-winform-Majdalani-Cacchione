using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace tp_winform_Majdalani_Cacchione
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaOriginal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaOriginal = negocio.listar();
            dgvlista.DataSource = listaOriginal;
            dgvlista.Columns[3].Visible = false;
            dgvlista.Columns[0].Visible = false;
        }

        private void dgvlista_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)dgvlista.CurrentRow.DataBoundItem;
                pbArticulo.Load(art.Imagen);
            }
            catch (Exception)
            {
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.ShowDialog();
            cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo Art;
            Art = (Articulo)dgvlista.CurrentRow.DataBoundItem;
            frmAlta modificar = new frmAlta(Art);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio art = new ArticuloNegocio();
            art.eliminar(((Articulo)dgvlista.CurrentRow.DataBoundItem).ID);
            MessageBox.Show("Eliminado correctamente", "Eliminación");
            cargar();
        }


        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtBuscar.Text=="")
            {
                dgvlista.DataSource = listaOriginal;
            }
            else
            {
                List<Articulo> ListaFiltrada = listaOriginal.FindAll(x => x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) || x.Descripción.ToLower().Contains(txtBuscar.Text.ToLower()));
                dgvlista.DataSource = ListaFiltrada;
            }
        }
    }
}
