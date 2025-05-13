namespace Aplicación_de_Control_de_Inventarios_para_una_Farmacia
{
    partial class LogindeUsuarios
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            textBox1 = new TextBox();
            btnIniciarSesion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(215, 89);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(318, 82);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(191, 146);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 146);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '.';
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(317, 247);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(120, 29);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 23);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "    Iniciar Sesión ";
            label1.Click += label1_Click;
            // 
            // LogindeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBox1);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "LogindeUsuarios";
            Text = "LogindeUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox textBox1;
        private Button btnIniciarSesion;
        private Label label1;
    }
}