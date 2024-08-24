namespace GestorProyectos
{
    partial class FormProyectos
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
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripProyectos = new System.Windows.Forms.MenuStrip();
            this.menuStripOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarFechaInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarFechaFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarOrden = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.menuStripProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9});
            this.dgvProyectos.Location = new System.Drawing.Point(12, 283);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(924, 256);
            this.dgvProyectos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tareas";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Empleados";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Presupuesto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Inico";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha Finalizacion";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Descripcion";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // menuStripProyectos
            // 
            this.menuStripProyectos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripProyectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripProyectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOrdenar});
            this.menuStripProyectos.Location = new System.Drawing.Point(0, 0);
            this.menuStripProyectos.Name = "menuStripProyectos";
            this.menuStripProyectos.Size = new System.Drawing.Size(967, 33);
            this.menuStripProyectos.TabIndex = 2;
            this.menuStripProyectos.Text = "menuStrip1";
            // 
            // menuStripOrdenar
            // 
            this.menuStripOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.msOrdenarNombre,
            this.msOrdenarEstado,
            this.msOrdenarCategoria,
            this.msOrdenarTareas,
            this.msOrdenarEmpleados,
            this.msOrdenarPresupuesto,
            this.msOrdenarFechaInicio,
            this.msOrdenarFechaFinal,
            this.toolStripSeparator2,
            this.msOrdenarOrden});
            this.menuStripOrdenar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripOrdenar.Name = "menuStripOrdenar";
            this.menuStripOrdenar.Size = new System.Drawing.Size(96, 29);
            this.menuStripOrdenar.Text = "Ordenar";
            // 
            // msOrdenarNombre
            // 
            this.msOrdenarNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarNombre.Name = "msOrdenarNombre";
            this.msOrdenarNombre.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarNombre.Text = "Nombre";
            // 
            // msOrdenarEstado
            // 
            this.msOrdenarEstado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEstado.Name = "msOrdenarEstado";
            this.msOrdenarEstado.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarEstado.Text = "Estado";
            // 
            // msOrdenarCategoria
            // 
            this.msOrdenarCategoria.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarCategoria.Name = "msOrdenarCategoria";
            this.msOrdenarCategoria.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarCategoria.Text = "Categoria";
            // 
            // msOrdenarTareas
            // 
            this.msOrdenarTareas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarTareas.Name = "msOrdenarTareas";
            this.msOrdenarTareas.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarTareas.Text = "Tareas";
            // 
            // msOrdenarEmpleados
            // 
            this.msOrdenarEmpleados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEmpleados.Name = "msOrdenarEmpleados";
            this.msOrdenarEmpleados.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarEmpleados.Text = "Empleados";
            // 
            // msOrdenarPresupuesto
            // 
            this.msOrdenarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarPresupuesto.Name = "msOrdenarPresupuesto";
            this.msOrdenarPresupuesto.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarPresupuesto.Text = "Presupuesto";
            // 
            // msOrdenarFechaInicio
            // 
            this.msOrdenarFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaInicio.Name = "msOrdenarFechaInicio";
            this.msOrdenarFechaInicio.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarFechaInicio.Text = "Fecha Incio";
            // 
            // msOrdenarFechaFinal
            // 
            this.msOrdenarFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaFinal.Name = "msOrdenarFechaFinal";
            this.msOrdenarFechaFinal.Size = new System.Drawing.Size(224, 30);
            this.msOrdenarFechaFinal.Text = "Fecha Final";
            // 
            // msOrdenarOrden
            // 
            this.msOrdenarOrden.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msOrdenarOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.msOrdenarOrden.Name = "msOrdenarOrden";
            this.msOrdenarOrden.Size = new System.Drawing.Size(121, 33);
            this.msOrdenarOrden.Text = "Orden ⬇️⬆️";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.menuStripProyectos);
            this.Name = "FormProyectos";
            this.Text = "FormProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.menuStripProyectos.ResumeLayout(false);
            this.menuStripProyectos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.MenuStrip menuStripProyectos;
        private System.Windows.Forms.ToolStripMenuItem menuStripOrdenar;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarNombre;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarEstado;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarCategoria;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarTareas;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarEmpleados;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarFechaInicio;
        private System.Windows.Forms.ToolStripMenuItem msOrdenarFechaFinal;
        private System.Windows.Forms.ToolStripComboBox msOrdenarOrden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}