namespace Aplicación_de_Control_de_Inventarios_para_una_Farmacia
{
    partial class RegistrodeVentas
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
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            lblPrecioTotal = new Label();
            btnAgregarProducto = new Button();
            btnFinalizarVenta = new Button();
            btnCancelarVenta = new Button();
            txtPrecioTotal = new TextBox();
            dgvProductosVenta = new DataGridView();
            lblRegistar = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(71, 70);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(183, 70);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(151, 28);
            cmbProducto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(71, 123);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(184, 123);
            numCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 3;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Location = new Point(49, 176);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(102, 20);
            lblPrecioTotal.TabIndex = 4;
            lblPrecioTotal.Text = "Precio Total: $";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(82, 237);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(146, 29);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(292, 237);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(128, 29);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(485, 237);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(115, 29);
            btnCancelarVenta.TabIndex = 7;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(185, 169);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(151, 27);
            txtPrecioTotal.TabIndex = 8;
            // 
            // dgvProductosVenta
            // 
            dgvProductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosVenta.Location = new Point(49, 297);
            dgvProductosVenta.Name = "dgvProductosVenta";
            dgvProductosVenta.ReadOnly = true;
            dgvProductosVenta.RowHeadersWidth = 51;
            dgvProductosVenta.Size = new Size(683, 141);
            dgvProductosVenta.TabIndex = 9;
            // 
            // lblRegistar
            // 
            lblRegistar.AutoSize = true;
            lblRegistar.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistar.Location = new Point(241, 18);
            lblRegistar.Name = "lblRegistar";
            lblRegistar.Size = new Size(277, 29);
            lblRegistar.TabIndex = 10;
            lblRegistar.Text = " Registro de Ventas ";
            // 
            // RegistrodeVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegistar);
            Controls.Add(dgvProductosVenta);
            Controls.Add(txtPrecioTotal);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblPrecioTotal);
            Controls.Add(numCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(lblProducto);
            Name = "RegistrodeVentas";
            Text = "RegistrodeVentas";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Label lblPrecioTotal;
        private Button btnAgregarProducto;
        private Button btnFinalizarVenta;
        private Button btnCancelarVenta;
        private TextBox txtPrecioTotal;
        private DataGridView dgvProductosVenta;
        private Label lblRegistar;
    }
}