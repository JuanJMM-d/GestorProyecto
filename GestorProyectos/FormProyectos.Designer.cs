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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.menuStripProyectos = new System.Windows.Forms.MenuStrip();
            this.menuStripOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msOrdenarNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarFechaInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msOrdenarFechaFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msOrdenarOrden = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxBuscarProyectos = new System.Windows.Forms.GroupBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.DTFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DTFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTEP = new System.Windows.Forms.TextBox();
            this.comboBoxTEP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrdenaEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblProyectoVer = new System.Windows.Forms.Label();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.menuStripProyectos.SuspendLayout();
            this.grpboxBuscarProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProyectos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProyectos.Location = new System.Drawing.Point(11, 188);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 35;
            this.dgvProyectos.Size = new System.Drawing.Size(703, 184);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
            // 
            // menuStripProyectos
            // 
            this.menuStripProyectos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripProyectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripProyectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOrdenar});
            this.menuStripProyectos.Location = new System.Drawing.Point(0, 0);
            this.menuStripProyectos.Name = "menuStripProyectos";
            this.menuStripProyectos.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripProyectos.Size = new System.Drawing.Size(725, 28);
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
            this.menuStripOrdenar.Size = new System.Drawing.Size(78, 24);
            this.menuStripOrdenar.Text = "Ordenar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // msOrdenarNombre
            // 
            this.msOrdenarNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarNombre.Name = "msOrdenarNombre";
            this.msOrdenarNombre.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarNombre.Text = "Nombre";
            // 
            // msOrdenarEstado
            // 
            this.msOrdenarEstado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEstado.Name = "msOrdenarEstado";
            this.msOrdenarEstado.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarEstado.Text = "Estado";
            // 
            // msOrdenarCategoria
            // 
            this.msOrdenarCategoria.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarCategoria.Name = "msOrdenarCategoria";
            this.msOrdenarCategoria.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarCategoria.Text = "Categoria";
            // 
            // msOrdenarTareas
            // 
            this.msOrdenarTareas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarTareas.Name = "msOrdenarTareas";
            this.msOrdenarTareas.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarTareas.Text = "Tareas";
            // 
            // msOrdenarEmpleados
            // 
            this.msOrdenarEmpleados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEmpleados.Name = "msOrdenarEmpleados";
            this.msOrdenarEmpleados.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarEmpleados.Text = "Empleados";
            // 
            // msOrdenarPresupuesto
            // 
            this.msOrdenarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarPresupuesto.Name = "msOrdenarPresupuesto";
            this.msOrdenarPresupuesto.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarPresupuesto.Text = "Presupuesto";
            // 
            // msOrdenarFechaInicio
            // 
            this.msOrdenarFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaInicio.Name = "msOrdenarFechaInicio";
            this.msOrdenarFechaInicio.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarFechaInicio.Text = "Fecha Incio";
            // 
            // msOrdenarFechaFinal
            // 
            this.msOrdenarFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaFinal.Name = "msOrdenarFechaFinal";
            this.msOrdenarFechaFinal.Size = new System.Drawing.Size(181, 24);
            this.msOrdenarFechaFinal.Text = "Fecha Final";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // msOrdenarOrden
            // 
            this.msOrdenarOrden.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msOrdenarOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.msOrdenarOrden.Name = "msOrdenarOrden";
            this.msOrdenarOrden.Size = new System.Drawing.Size(121, 28);
            this.msOrdenarOrden.Text = "Orden ⬇️⬆️";
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
            // grpboxBuscarProyectos
            // 
            this.grpboxBuscarProyectos.Controls.Add(this.btnBuscarProyecto);
            this.grpboxBuscarProyectos.Controls.Add(this.DTFechaFinal);
            this.grpboxBuscarProyectos.Controls.Add(this.DTFechaInicio);
            this.grpboxBuscarProyectos.Controls.Add(this.label6);
            this.grpboxBuscarProyectos.Controls.Add(this.label5);
            this.grpboxBuscarProyectos.Controls.Add(this.txtTEP);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxTEP);
            this.grpboxBuscarProyectos.Controls.Add(this.label4);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxOrdenaEstado);
            this.grpboxBuscarProyectos.Controls.Add(this.label3);
            this.grpboxBuscarProyectos.Controls.Add(this.textBoxBuscarCategoria);
            this.grpboxBuscarProyectos.Controls.Add(this.label2);
            this.grpboxBuscarProyectos.Controls.Add(this.txtNombreBuscar);
            this.grpboxBuscarProyectos.Controls.Add(this.label1);
            this.grpboxBuscarProyectos.Location = new System.Drawing.Point(63, 30);
            this.grpboxBuscarProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxBuscarProyectos.Name = "grpboxBuscarProyectos";
            this.grpboxBuscarProyectos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxBuscarProyectos.Size = new System.Drawing.Size(614, 152);
            this.grpboxBuscarProyectos.TabIndex = 4;
            this.grpboxBuscarProyectos.TabStop = false;
            this.grpboxBuscarProyectos.Text = "Buscar";
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(522, 119);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(88, 29);
            this.btnBuscarProyecto.TabIndex = 16;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // DTFechaFinal
            // 
            this.DTFechaFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaFinal.Location = new System.Drawing.Point(360, 85);
            this.DTFechaFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTFechaFinal.Name = "DTFechaFinal";
            this.DTFechaFinal.Size = new System.Drawing.Size(151, 23);
            this.DTFechaFinal.TabIndex = 15;
            // 
            // DTFechaInicio
            // 
            this.DTFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaInicio.Location = new System.Drawing.Point(360, 55);
            this.DTFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTFechaInicio.Name = "DTFechaInicio";
            this.DTFechaInicio.Size = new System.Drawing.Size(151, 23);
            this.DTFechaInicio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Inicio:";
            // 
            // txtTEP
            // 
            this.txtTEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEP.Location = new System.Drawing.Point(455, 13);
            this.txtTEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTEP.Name = "txtTEP";
            this.txtTEP.Size = new System.Drawing.Size(74, 24);
            this.txtTEP.TabIndex = 11;
            // 
            // comboBoxTEP
            // 
            this.comboBoxTEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTEP.FormattingEnabled = true;
            this.comboBoxTEP.Items.AddRange(new object[] {
            "Tareas",
            "Empleados",
            "Presupuesto\t\t\t\t"});
            this.comboBoxTEP.Location = new System.Drawing.Point(334, 13);
            this.comboBoxTEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTEP.Name = "comboBoxTEP";
            this.comboBoxTEP.Size = new System.Drawing.Size(117, 25);
            this.comboBoxTEP.TabIndex = 10;
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
            // comboBoxOrdenaEstado
            // 
            this.comboBoxOrdenaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenaEstado.FormattingEnabled = true;
            this.comboBoxOrdenaEstado.Items.AddRange(new object[] {
            "En curso",
            "Finalizado",
            "Por empezar",
            "Pausado"});
            this.comboBoxOrdenaEstado.Location = new System.Drawing.Point(86, 84);
            this.comboBoxOrdenaEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxOrdenaEstado.Name = "comboBoxOrdenaEstado";
            this.comboBoxOrdenaEstado.Size = new System.Drawing.Size(117, 25);
            this.comboBoxOrdenaEstado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            // 
            // textBoxBuscarCategoria
            // 
            this.textBoxBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarCategoria.Location = new System.Drawing.Point(86, 50);
            this.textBoxBuscarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscarCategoria.Name = "textBoxBuscarCategoria";
            this.textBoxBuscarCategoria.Size = new System.Drawing.Size(114, 24);
            this.textBoxBuscarCategoria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(75, 17);
            this.txtNombreBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(126, 23);
            this.txtNombreBuscar.TabIndex = 4;
            // 
            // lblProyectoVer
            // 
            this.lblProyectoVer.AutoSize = true;
            this.lblProyectoVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectoVer.Location = new System.Drawing.Point(259, 374);
            this.lblProyectoVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProyectoVer.Name = "lblProyectoVer";
            this.lblProyectoVer.Size = new System.Drawing.Size(215, 24);
            this.lblProyectoVer.TabIndex = 17;
            this.lblProyectoVer.Text = "ID Proyecto:    , Nombre:";
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.Location = new System.Drawing.Point(242, 411);
            this.btnVerTareas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Size = new System.Drawing.Size(108, 37);
            this.btnVerTareas.TabIndex = 18;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = true;
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpleados.Location = new System.Drawing.Point(379, 411);
            this.btnVerEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(126, 37);
            this.btnVerEmpleados.TabIndex = 19;
            this.btnVerEmpleados.Text = "Ver Empleados";
            this.btnVerEmpleados.UseVisualStyleBackColor = true;
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.btnVerEmpleados);
            this.Controls.Add(this.btnVerTareas);
            this.Controls.Add(this.lblProyectoVer);
            this.Controls.Add(this.grpboxBuscarProyectos);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.menuStripProyectos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProyectos";
            this.Text = "FormProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.menuStripProyectos.ResumeLayout(false);
            this.menuStripProyectos.PerformLayout();
            this.grpboxBuscarProyectos.ResumeLayout(false);
            this.grpboxBuscarProyectos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyectos;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxBuscarProyectos;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOrdenaEstado;
        private System.Windows.Forms.ComboBox comboBoxTEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTEP;
        private System.Windows.Forms.DateTimePicker DTFechaFinal;
        private System.Windows.Forms.DateTimePicker DTFechaInicio;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.Label lblProyectoVer;
        private System.Windows.Forms.Button btnVerTareas;
        private System.Windows.Forms.Button btnVerEmpleados;
    }
}