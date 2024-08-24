namespace GestorProyectos
{
    partial class FormCrearTarea
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
            this.groupBoxTareas = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTareaEstado = new System.Windows.Forms.ComboBox();
            this.btnAddTarea = new System.Windows.Forms.Button();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRolEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AddEmpleado = new System.Windows.Forms.Button();
            this.grpEmpleados = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.groupBoxTareas.SuspendLayout();
            this.grpEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTareas
            // 
            this.groupBoxTareas.Controls.Add(this.btnNuevaTarea);
            this.groupBoxTareas.Controls.Add(this.txtDescripcionTarea);
            this.groupBoxTareas.Controls.Add(this.label6);
            this.groupBoxTareas.Controls.Add(this.grpEmpleados);
            this.groupBoxTareas.Controls.Add(this.btnAddTarea);
            this.groupBoxTareas.Controls.Add(this.comboBoxTareaEstado);
            this.groupBoxTareas.Controls.Add(this.label11);
            this.groupBoxTareas.Controls.Add(this.txtNombreTarea);
            this.groupBoxTareas.Controls.Add(this.label9);
            this.groupBoxTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTareas.Location = new System.Drawing.Point(0, 12);
            this.groupBoxTareas.Name = "groupBoxTareas";
            this.groupBoxTareas.Size = new System.Drawing.Size(858, 471);
            this.groupBoxTareas.TabIndex = 17;
            this.groupBoxTareas.TabStop = false;
            this.groupBoxTareas.Text = "Tareas";
            this.groupBoxTareas.Enter += new System.EventHandler(this.groupBoxTareas_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTarea.Location = new System.Drawing.Point(150, 40);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(212, 28);
            this.txtNombreTarea.TabIndex = 20;
            this.txtNombreTarea.TextChanged += new System.EventHandler(this.txtNombreTarea_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nombre:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTareaEstado
            // 
            this.comboBoxTareaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTareaEstado.FormattingEnabled = true;
            this.comboBoxTareaEstado.Items.AddRange(new object[] {
            "En curso",
            "Finalizado",
            "Por empezar",
            "Pausado"});
            this.comboBoxTareaEstado.Location = new System.Drawing.Point(150, 97);
            this.comboBoxTareaEstado.Name = "comboBoxTareaEstado";
            this.comboBoxTareaEstado.Size = new System.Drawing.Size(212, 30);
            this.comboBoxTareaEstado.TabIndex = 22;
            this.comboBoxTareaEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxTareaEstado_SelectedIndexChanged);
            // 
            // btnAddTarea
            // 
            this.btnAddTarea.Location = new System.Drawing.Point(561, 361);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(161, 49);
            this.btnAddTarea.TabIndex = 27;
            this.btnAddTarea.Text = "Add Tarea";
            this.btnAddTarea.UseVisualStyleBackColor = true;
            this.btnAddTarea.Click += new System.EventHandler(this.btnAddTarea_Click);
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(132, 66);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(212, 28);
            this.txtEmpleadoNombre.TabIndex = 21;
            this.txtEmpleadoNombre.TextChanged += new System.EventHandler(this.txtEmpleadoNombre_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre E:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRolEmpleado
            // 
            this.txtRolEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolEmpleado.Location = new System.Drawing.Point(132, 108);
            this.txtRolEmpleado.Name = "txtRolEmpleado";
            this.txtRolEmpleado.Size = new System.Drawing.Size(212, 28);
            this.txtRolEmpleado.TabIndex = 23;
            this.txtRolEmpleado.TextChanged += new System.EventHandler(this.txtRolEmpleado_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rol E:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(132, 27);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(212, 28);
            this.txtIdEmpleado.TabIndex = 25;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEmpleado_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Id E:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmpleado
            // 
            this.AddEmpleado.Location = new System.Drawing.Point(199, 152);
            this.AddEmpleado.Name = "AddEmpleado";
            this.AddEmpleado.Size = new System.Drawing.Size(134, 27);
            this.AddEmpleado.TabIndex = 26;
            this.AddEmpleado.Text = "add Empleado";
            this.AddEmpleado.UseVisualStyleBackColor = true;
            this.AddEmpleado.Click += new System.EventHandler(this.AddEmpleado_Click);
            // 
            // grpEmpleados
            // 
            this.grpEmpleados.Controls.Add(this.AddEmpleado);
            this.grpEmpleados.Controls.Add(this.label13);
            this.grpEmpleados.Controls.Add(this.txtIdEmpleado);
            this.grpEmpleados.Controls.Add(this.label12);
            this.grpEmpleados.Controls.Add(this.txtRolEmpleado);
            this.grpEmpleados.Controls.Add(this.label10);
            this.grpEmpleados.Controls.Add(this.txtEmpleadoNombre);
            this.grpEmpleados.Location = new System.Drawing.Point(465, 52);
            this.grpEmpleados.Name = "grpEmpleados";
            this.grpEmpleados.Size = new System.Drawing.Size(380, 193);
            this.grpEmpleados.TabIndex = 23;
            this.grpEmpleados.TabStop = false;
            this.grpEmpleados.Text = "Empleado de esta Tarea";
            this.toolTipAyuda.SetToolTip(this.grpEmpleados, "Agrega primero una Tarea");
            this.grpEmpleados.Enter += new System.EventHandler(this.grpEmpleados_Enter);
            this.grpEmpleados.MouseHover += new System.EventHandler(this.grpEmpleados_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Descripcion:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionTarea.Location = new System.Drawing.Point(35, 202);
            this.txtDescripcionTarea.Multiline = true;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(380, 240);
            this.txtDescripcionTarea.TabIndex = 28;
            this.txtDescripcionTarea.TextChanged += new System.EventHandler(this.txtDescripcionTarea_TextChanged);
            // 
            // toolTipAyuda
            // 
            this.toolTipAyuda.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipAyuda_Popup);
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.Location = new System.Drawing.Point(561, 306);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(161, 49);
            this.btnNuevaTarea.TabIndex = 29;
            this.btnNuevaTarea.Text = "Nueva Tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = true;
            this.btnNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
            // 
            // FormCrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 482);
            this.Controls.Add(this.groupBoxTareas);
            this.Name = "FormCrearTarea";
            this.Text = "FormCrearTarea";
            this.Load += new System.EventHandler(this.FormCrearTarea_Load);
            this.groupBoxTareas.ResumeLayout(false);
            this.groupBoxTareas.PerformLayout();
            this.grpEmpleados.ResumeLayout(false);
            this.grpEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTareas;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpEmpleados;
        private System.Windows.Forms.Button AddEmpleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRolEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.Button btnAddTarea;
        private System.Windows.Forms.ComboBox comboBoxTareaEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.Button btnNuevaTarea;
    }
}