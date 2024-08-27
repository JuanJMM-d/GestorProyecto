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
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.txtSalariomax = new System.Windows.Forms.TextBox();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.txtBuscarIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.grpboxBuscarProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 231);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(898, 234);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
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
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // grpboxBuscarProyectos
            // 
            this.grpboxBuscarProyectos.Controls.Add(this.btnLimpiarFiltros);
            this.grpboxBuscarProyectos.Controls.Add(this.txtSalariomax);
            this.grpboxBuscarProyectos.Controls.Add(this.txtSalarioMin);
            this.grpboxBuscarProyectos.Controls.Add(this.txtBuscarIdEmpleado);
            this.grpboxBuscarProyectos.Controls.Add(this.label2);
            this.grpboxBuscarProyectos.Controls.Add(this.btnBuscarProyecto);
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
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(648, 76);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(117, 36);
            this.btnLimpiarFiltros.TabIndex = 23;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // txtSalariomax
            // 
            this.txtSalariomax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalariomax.Location = new System.Drawing.Point(678, 22);
            this.txtSalariomax.Name = "txtSalariomax";
            this.txtSalariomax.Size = new System.Drawing.Size(97, 28);
            this.txtSalariomax.TabIndex = 22;
            this.txtSalariomax.TextChanged += new System.EventHandler(this.txtSalariomax_TextChanged);
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMin.Location = new System.Drawing.Point(558, 21);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(97, 28);
            this.txtSalarioMin.TabIndex = 21;
            this.txtSalarioMin.TextChanged += new System.EventHandler(this.txtSalarioMin_TextChanged);
            // 
            // txtBuscarIdEmpleado
            // 
            this.txtBuscarIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIdEmpleado.Location = new System.Drawing.Point(100, 76);
            this.txtBuscarIdEmpleado.Name = "txtBuscarIdEmpleado";
            this.txtBuscarIdEmpleado.Size = new System.Drawing.Size(166, 27);
            this.txtBuscarIdEmpleado.TabIndex = 18;
            this.txtBuscarIdEmpleado.TextChanged += new System.EventHandler(this.txtBuscarIdEmpleado_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salario:";
            // 
            // txtNombreBuscarEmpleado
            // 
            this.txtNombreBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscarEmpleado.Location = new System.Drawing.Point(100, 21);
            this.txtNombreBuscarEmpleado.Name = "txtNombreBuscarEmpleado";
            this.txtNombreBuscarEmpleado.Size = new System.Drawing.Size(166, 27);
            this.txtNombreBuscarEmpleado.TabIndex = 4;
            this.txtNombreBuscarEmpleado.TextChanged += new System.EventHandler(this.txtNombreBuscarEmpleado_TextChanged);
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
            this.Load += new System.EventHandler(this.FormEmpleadosInicio_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreBuscarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalariomax;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}