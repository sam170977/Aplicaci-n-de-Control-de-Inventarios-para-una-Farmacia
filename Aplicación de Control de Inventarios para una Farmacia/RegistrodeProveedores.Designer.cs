namespace Aplicación_de_Control_de_Inventarios_para_una_Farmacia
{
    partial class RegistrodeProveedores
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblProveedores = new Label();
            txtTelefono = new TextBox();
            lblProductos = new Label();
            clbProductos = new CheckedListBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(222, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(40, 148);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(150, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono de contacto";
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Location = new Point(295, 39);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(175, 20);
            lblProveedores.TabIndex = 3;
            lblProveedores.Text = " Registro de Proveedores";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(222, 148);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 4;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(40, 212);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(175, 20);
            lblProductos.TabIndex = 5;
            lblProductos.Text = "Productos que suministra";
            // 
            // clbProductos
            // 
            clbProductos.FormattingEnabled = true;
            clbProductos.Location = new Point(237, 212);
            clbProductos.Name = "clbProductos";
            clbProductos.Size = new Size(172, 48);
            clbProductos.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(69, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(253, 335);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(432, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // RegistrodeProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(clbProductos);
            Controls.Add(lblProductos);
            Controls.Add(txtTelefono);
            Controls.Add(lblProveedores);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "RegistrodeProveedores";
            Text = "RegistrodeProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblProveedores;
        private TextBox txtTelefono;
        private Label lblProductos;
        private CheckedListBox clbProductos;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}