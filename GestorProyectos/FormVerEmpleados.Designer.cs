namespace GestorProyectos
{
    partial class FormVerEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Salario,
            this.Administrador});
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(GestorProyectos.Code.Users.Usuarios);
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "UserName";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            this.Administrador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Administrador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormVerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 458);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVerEmpleados";
            this.Text = "Ver Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Administrador;
    }
}