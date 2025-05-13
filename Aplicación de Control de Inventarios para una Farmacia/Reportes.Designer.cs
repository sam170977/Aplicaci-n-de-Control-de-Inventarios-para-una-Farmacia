namespace Aplicación_de_Control_de_Inventarios_para_una_Farmacia
{
    partial class Reportes
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
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            lblFiltro = new Label();
            cmbFiltro = new ComboBox();
            btnGenerarReporte = new Button();
            lblReporte = new Label();
            dgvReporte = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(171, 71);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(287, 27);
            dtpFechaInicio.TabIndex = 0;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(171, 147);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(276, 27);
            dtpFechaFin.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(59, 71);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(90, 20);
            lblFechaInicio.TabIndex = 2;
            lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(59, 147);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(77, 20);
            lblFechaFin.TabIndex = 3;
            lblFechaFin.Text = "Fecha Fin: ";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(59, 219);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(73, 20);
            lblFiltro.TabIndex = 4;
            lblFiltro.Text = "Filtro por:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(171, 219);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(151, 28);
            cmbFiltro.TabIndex = 5;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(358, 215);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(160, 29);
            btnGenerarReporte.TabIndex = 6;
            btnGenerarReporte.Text = "generar el reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.Location = new Point(59, 280);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(146, 20);
            lblReporte.TabIndex = 7;
            lblReporte.Text = " Reporte Generado:  ";
            lblReporte.Click += lblReporte_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(211, 280);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(286, 158);
            dgvReporte.TabIndex = 8;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReporte);
            Controls.Add(lblReporte);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cmbFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblFiltro;
        private ComboBox cmbFiltro;
        private Button btnGenerarReporte;
        private Label lblReporte;
        private DataGridView dgvReporte;
    }
}