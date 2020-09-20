namespace tp_winform_Majdalani_Cacchione
{
    partial class frmAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvlCodigo = new System.Windows.Forms.Label();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.lvlDescripcion = new System.Windows.Forms.Label();
            this.lvlPrecio = new System.Windows.Forms.Label();
            this.lvlImagen = new System.Windows.Forms.Label();
            this.lvlMarca = new System.Windows.Forms.Label();
            this.lvlCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlCodigo
            // 
            this.lvlCodigo.AutoSize = true;
            this.lvlCodigo.Location = new System.Drawing.Point(57, 67);
            this.lvlCodigo.Name = "lvlCodigo";
            this.lvlCodigo.Size = new System.Drawing.Size(40, 13);
            this.lvlCodigo.TabIndex = 0;
            this.lvlCodigo.Text = "Codigo";
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(53, 132);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(44, 13);
            this.lvlNombre.TabIndex = 1;
            this.lvlNombre.Text = "Nombre";
            // 
            // lvlDescripcion
            // 
            this.lvlDescripcion.AutoSize = true;
            this.lvlDescripcion.Location = new System.Drawing.Point(34, 197);
            this.lvlDescripcion.Name = "lvlDescripcion";
            this.lvlDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lvlDescripcion.TabIndex = 2;
            this.lvlDescripcion.Text = "Descripción";
            // 
            // lvlPrecio
            // 
            this.lvlPrecio.AutoSize = true;
            this.lvlPrecio.Location = new System.Drawing.Point(60, 262);
            this.lvlPrecio.Name = "lvlPrecio";
            this.lvlPrecio.Size = new System.Drawing.Size(37, 13);
            this.lvlPrecio.TabIndex = 3;
            this.lvlPrecio.Text = "Precio";
            // 
            // lvlImagen
            // 
            this.lvlImagen.AutoSize = true;
            this.lvlImagen.Location = new System.Drawing.Point(313, 195);
            this.lvlImagen.Name = "lvlImagen";
            this.lvlImagen.Size = new System.Drawing.Size(42, 13);
            this.lvlImagen.TabIndex = 4;
            this.lvlImagen.Text = "Imagen";
            // 
            // lvlMarca
            // 
            this.lvlMarca.AutoSize = true;
            this.lvlMarca.Location = new System.Drawing.Point(315, 67);
            this.lvlMarca.Name = "lvlMarca";
            this.lvlMarca.Size = new System.Drawing.Size(37, 13);
            this.lvlMarca.TabIndex = 5;
            this.lvlMarca.Text = "Marca";
            // 
            // lvlCategoria
            // 
            this.lvlCategoria.AutoSize = true;
            this.lvlCategoria.Location = new System.Drawing.Point(305, 131);
            this.lvlCategoria.Name = "lvlCategoria";
            this.lvlCategoria.Size = new System.Drawing.Size(54, 13);
            this.lvlCategoria.TabIndex = 6;
            this.lvlCategoria.Text = "Categoría";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 194);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(151, 262);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(413, 196);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 11;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(411, 58);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 12;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(413, 127);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 13;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // btnAgregarAlta
            // 
            this.btnAgregarAlta.Location = new System.Drawing.Point(176, 328);
            this.btnAgregarAlta.Name = "btnAgregarAlta";
            this.btnAgregarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAlta.TabIndex = 14;
            this.btnAgregarAlta.Text = "Aceptar";
            this.btnAgregarAlta.UseVisualStyleBackColor = true;
            this.btnAgregarAlta.Click += new System.EventHandler(this.btnAgregarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(413, 328);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAlta.TabIndex = 15;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 410);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lvlPrecio);
            this.Controls.Add(this.lvlDescripcion);
            this.Controls.Add(this.lvlNombre);
            this.Controls.Add(this.lvlCodigo);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnAgregarAlta);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lvlCategoria);
            this.Controls.Add(this.lvlMarca);
            this.Controls.Add(this.lvlImagen);
            this.Name = "frmAlta";
            this.Text = "Alta de Artículo";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlCodigo;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.Label lvlDescripcion;
        private System.Windows.Forms.Label lvlPrecio;
        private System.Windows.Forms.Label lvlImagen;
        private System.Windows.Forms.Label lvlMarca;
        private System.Windows.Forms.Label lvlCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}