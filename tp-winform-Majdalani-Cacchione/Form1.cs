﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvlista.DataSource = negocio.listar();
            dgvlista.Columns[2].Visible = false;
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
    }
}