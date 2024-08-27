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
            this.txtBuscarIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.txtPTRmin = new System.Windows.Forms.TextBox();
            this.comboBoxPTR = new System.Windows.Forms.ComboBox();
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
            this.dgvEmpleados.Location = new System.Drawing.Point(9, 188);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(674, 190);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(9, 140);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(153, 43);
            this.btnCrearEmpleado.TabIndex = 1;
            this.btnCrearEmpleado.Text = "Añadir Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // grpboxBuscarProyectos
            // 
            this.grpboxBuscarProyectos.Controls.Add(this.txtBuscarIdEmpleado);
            this.grpboxBuscarProyectos.Controls.Add(this.label2);
            this.grpboxBuscarProyectos.Controls.Add(this.btnBuscarProyecto);
            this.grpboxBuscarProyectos.Controls.Add(this.txtPTRmin);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxPTR);
            this.grpboxBuscarProyectos.Controls.Add(this.label4);
            this.grpboxBuscarProyectos.Controls.Add(this.txtNombreBuscarEmpleado);
            this.grpboxBuscarProyectos.Controls.Add(this.label1);
            this.grpboxBuscarProyectos.Location = new System.Drawing.Point(52, 10);
            this.grpboxBuscarProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.grpboxBuscarProyectos.Name = "grpboxBuscarProyectos";
            this.grpboxBuscarProyectos.Padding = new System.Windows.Forms.Padding(2);
            this.grpboxBuscarProyectos.Size = new System.Drawing.Size(614, 110);
            this.grpboxBuscarProyectos.TabIndex = 5;
            this.grpboxBuscarProyectos.TabStop = false;
            this.grpboxBuscarProyectos.Text = "groupBox1";
            // 
            // txtBuscarIdEmpleado
            // 
            this.txtBuscarIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIdEmpleado.Location = new System.Drawing.Point(75, 62);
            this.txtBuscarIdEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarIdEmpleado.Name = "txtBuscarIdEmpleado";
            this.txtBuscarIdEmpleado.Size = new System.Drawing.Size(126, 23);
            this.txtBuscarIdEmpleado.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID:";
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(318, 57);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(88, 29);
            this.btnBuscarProyecto.TabIndex = 16;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            // 
            // txtPTRmin
            // 
            this.txtPTRmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTRmin.Location = new System.Drawing.Point(455, 13);
            this.txtPTRmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPTRmin.Name = "txtPTRmin";
            this.txtPTRmin.Size = new System.Drawing.Size(74, 24);
            this.txtPTRmin.TabIndex = 11;
            this.txtPTRmin.TextChanged += new System.EventHandler(this.txtPTRmin_TextChanged);
            // 
            // comboBoxPTR
            // 
            this.comboBoxPTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPTR.FormattingEnabled = true;
            this.comboBoxPTR.Items.AddRange(new object[] {
            "Tareas",
            "Empleados",
            "Presupuesto\t\t\t\t"});
            this.comboBoxPTR.Location = new System.Drawing.Point(334, 13);
            this.comboBoxPTR.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPTR.Name = "comboBoxPTR";
            this.comboBoxPTR.Size = new System.Drawing.Size(117, 25);
            this.comboBoxPTR.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Catidad de:";
            // 
            // txtNombreBuscarEmpleado
            // 
            this.txtNombreBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscarEmpleado.Location = new System.Drawing.Point(75, 17);
            this.txtNombreBuscarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBuscarEmpleado.Name = "txtNombreBuscarEmpleado";
            this.txtNombreBuscarEmpleado.Size = new System.Drawing.Size(126, 23);
            this.txtNombreBuscarEmpleado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // FormEmpleadosInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.grpboxBuscarProyectos);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmpleadosInicio";
            this.Text = "Inicio (Empleado)";
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
        private System.Windows.Forms.TextBox txtPTRmin;
        private System.Windows.Forms.ComboBox comboBoxPTR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreBuscarEmpleado;
        private System.Windows.Forms.Label label1;
    }
}