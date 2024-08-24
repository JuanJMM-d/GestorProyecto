namespace GestorProyectos
{
    partial class FormEmpleadosInicio
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.grpboxBuscarProyectos = new System.Windows.Forms.GroupBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.txtPTR = new System.Windows.Forms.TextBox();
            this.comboBoxPTR = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.grpboxBuscarProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 231);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(898, 234);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(12, 172);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(181, 53);
            this.btnCrearEmpleado.TabIndex = 1;
            this.btnCrearEmpleado.Text = "Añadir Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // grpboxBuscarProyectos
            // 
            this.grpboxBuscarProyectos.Controls.Add(this.txtBuscarIdEmpleado);
            this.grpboxBuscarProyectos.Controls.Add(this.label2);
            this.grpboxBuscarProyectos.Controls.Add(this.btnBuscarProyecto);
            this.grpboxBuscarProyectos.Controls.Add(this.txtPTR);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxPTR);
            this.grpboxBuscarProyectos.Controls.Add(this.label4);
            this.grpboxBuscarProyectos.Controls.Add(this.txtNombreBuscarEmpleado);
            this.grpboxBuscarProyectos.Controls.Add(this.label1);
            this.grpboxBuscarProyectos.Location = new System.Drawing.Point(70, 12);
            this.grpboxBuscarProyectos.Name = "grpboxBuscarProyectos";
            this.grpboxBuscarProyectos.Size = new System.Drawing.Size(818, 136);
            this.grpboxBuscarProyectos.TabIndex = 5;
            this.grpboxBuscarProyectos.TabStop = false;
            this.grpboxBuscarProyectos.Text = "groupBox1";
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(424, 70);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(117, 36);
            this.btnBuscarProyecto.TabIndex = 16;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            // 
            // txtPTR
            // 
            this.txtPTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTR.Location = new System.Drawing.Point(607, 16);
            this.txtPTR.Name = "txtPTR";
            this.txtPTR.Size = new System.Drawing.Size(97, 28);
            this.txtPTR.TabIndex = 11;
            // 
            // comboBoxPTR
            // 
            this.comboBoxPTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPTR.FormattingEnabled = true;
            this.comboBoxPTR.Items.AddRange(new object[] {
            "Tareas",
            "Empleados",
            "Presupuesto\t\t\t\t"});
            this.comboBoxPTR.Location = new System.Drawing.Point(446, 16);
            this.comboBoxPTR.Name = "comboBoxPTR";
            this.comboBoxPTR.Size = new System.Drawing.Size(155, 28);
            this.comboBoxPTR.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Catidad de:";
            // 
            // txtNombreBuscarEmpleado
            // 
            this.txtNombreBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscarEmpleado.Location = new System.Drawing.Point(100, 21);
            this.txtNombreBuscarEmpleado.Name = "txtNombreBuscarEmpleado";
            this.txtNombreBuscarEmpleado.Size = new System.Drawing.Size(166, 27);
            this.txtNombreBuscarEmpleado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // txtBuscarIdEmpleado
            // 
            this.txtBuscarIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIdEmpleado.Location = new System.Drawing.Point(100, 76);
            this.txtBuscarIdEmpleado.Name = "txtBuscarIdEmpleado";
            this.txtBuscarIdEmpleado.Size = new System.Drawing.Size(166, 27);
            this.txtBuscarIdEmpleado.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Empleado";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Proyectos";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tareas";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Roles";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salario";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // FormEmpleadosInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.grpboxBuscarProyectos);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FormEmpleadosInicio";
            this.Text = "FormEmpleadosInicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.grpboxBuscarProyectos.ResumeLayout(false);
            this.grpboxBuscarProyectos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.GroupBox grpboxBuscarProyectos;
        private System.Windows.Forms.TextBox txtBuscarIdEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.TextBox txtPTR;
        private System.Windows.Forms.ComboBox comboBoxPTR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreBuscarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}