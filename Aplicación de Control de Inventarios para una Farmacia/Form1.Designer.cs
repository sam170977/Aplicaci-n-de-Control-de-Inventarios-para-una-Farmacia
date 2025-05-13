namespace Aplicación_de_Control_de_Inventarios_para_una_Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            numPrecio = new NumericUpDown();
            lblStock = new Label();
            numMinimo = new NumericUpDown();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(55, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(153, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(250, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(86, 89);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(250, 89);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 34);
            txtDescripcion.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(106, 146);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(250, 146);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(150, 27);
            numPrecio.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(79, 204);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(129, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Cantidad en Stock";
            // 
            // numMinimo
            // 
            numMinimo.Location = new Point(250, 202);
            numMinimo.Name = "numMinimo";
            numMinimo.Size = new Size(150, 27);
            numMinimo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(106, 262);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(281, 262);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(427, 265);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(563, 262);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(33, 315);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(734, 106);
            dgvProductos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(numMinimo);
            Controls.Add(lblStock);
            Controls.Add(numPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecio;
        private NumericUpDown numPrecio;
        private Label lblStock;
        private NumericUpDown numMinimo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvProductos;
    }
}
