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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtTEPmax = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.DTFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DTFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTEPmin = new System.Windows.Forms.TextBox();
            this.comboBoxTEP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrdenaEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblProyectoVer = new System.Windows.Forms.Label();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.btnEditarProyecto = new System.Windows.Forms.Button();
            this.btnElimarProyecto = new System.Windows.Forms.Button();
            this.btnEditarTaea = new System.Windows.Forms.Button();
            this.btnVerDescripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.menuStripProyectos.SuspendLayout();
            this.grpboxBuscarProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProyectos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProyectos.Location = new System.Drawing.Point(12, 217);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 35;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(924, 227);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
            this.dgvProyectos.SelectionChanged += new System.EventHandler(this.dgvProyectos_SelectionChanged);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // msOrdenarNombre
            // 
            this.msOrdenarNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarNombre.Name = "msOrdenarNombre";
            this.msOrdenarNombre.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarNombre.Text = "Nombre";
            // 
            // msOrdenarEstado
            // 
            this.msOrdenarEstado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEstado.Name = "msOrdenarEstado";
            this.msOrdenarEstado.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarEstado.Text = "Estado";
            // 
            // msOrdenarCategoria
            // 
            this.msOrdenarCategoria.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarCategoria.Name = "msOrdenarCategoria";
            this.msOrdenarCategoria.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarCategoria.Text = "Categoria";
            // 
            // msOrdenarTareas
            // 
            this.msOrdenarTareas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarTareas.Name = "msOrdenarTareas";
            this.msOrdenarTareas.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarTareas.Text = "Tareas";
            // 
            // msOrdenarEmpleados
            // 
            this.msOrdenarEmpleados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarEmpleados.Name = "msOrdenarEmpleados";
            this.msOrdenarEmpleados.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarEmpleados.Text = "Empleados";
            // 
            // msOrdenarPresupuesto
            // 
            this.msOrdenarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarPresupuesto.Name = "msOrdenarPresupuesto";
            this.msOrdenarPresupuesto.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarPresupuesto.Text = "Presupuesto";
            // 
            // msOrdenarFechaInicio
            // 
            this.msOrdenarFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaInicio.Name = "msOrdenarFechaInicio";
            this.msOrdenarFechaInicio.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarFechaInicio.Text = "Fecha Incio";
            // 
            // msOrdenarFechaFinal
            // 
            this.msOrdenarFechaFinal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOrdenarFechaFinal.Name = "msOrdenarFechaFinal";
            this.msOrdenarFechaFinal.Size = new System.Drawing.Size(196, 30);
            this.msOrdenarFechaFinal.Text = "Fecha Final";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
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
            // grpboxBuscarProyectos
            // 
            this.grpboxBuscarProyectos.Controls.Add(this.txtTEPmax);
            this.grpboxBuscarProyectos.Controls.Add(this.btnLimpiarFiltros);
            this.grpboxBuscarProyectos.Controls.Add(this.btnBuscarProyecto);
            this.grpboxBuscarProyectos.Controls.Add(this.DTFechaFinal);
            this.grpboxBuscarProyectos.Controls.Add(this.DTFechaInicio);
            this.grpboxBuscarProyectos.Controls.Add(this.label6);
            this.grpboxBuscarProyectos.Controls.Add(this.label5);
            this.grpboxBuscarProyectos.Controls.Add(this.txtTEPmin);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxTEP);
            this.grpboxBuscarProyectos.Controls.Add(this.label4);
            this.grpboxBuscarProyectos.Controls.Add(this.comboBoxOrdenaEstado);
            this.grpboxBuscarProyectos.Controls.Add(this.label3);
            this.grpboxBuscarProyectos.Controls.Add(this.textBoxBuscarCategoria);
            this.grpboxBuscarProyectos.Controls.Add(this.label2);
            this.grpboxBuscarProyectos.Controls.Add(this.txtNombreBuscar);
            this.grpboxBuscarProyectos.Controls.Add(this.label1);
            this.grpboxBuscarProyectos.Location = new System.Drawing.Point(118, 12);
            this.grpboxBuscarProyectos.Name = "grpboxBuscarProyectos";
            this.grpboxBuscarProyectos.Size = new System.Drawing.Size(818, 187);
            this.grpboxBuscarProyectos.TabIndex = 4;
            this.grpboxBuscarProyectos.TabStop = false;
            this.grpboxBuscarProyectos.Text = "groupBox1";
            // 
            // txtTEPmax
            // 
            this.txtTEPmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEPmax.Location = new System.Drawing.Point(710, 18);
            this.txtTEPmax.Name = "txtTEPmax";
            this.txtTEPmax.Size = new System.Drawing.Size(97, 28);
            this.txtTEPmax.TabIndex = 18;
            this.txtTEPmax.TextChanged += new System.EventHandler(this.txtTEPmax_TextChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(671, 145);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(117, 36);
            this.btnLimpiarFiltros.TabIndex = 17;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(307, 145);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(117, 36);
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
            this.DTFechaFinal.Location = new System.Drawing.Point(480, 105);
            this.DTFechaFinal.Name = "DTFechaFinal";
            this.DTFechaFinal.Size = new System.Drawing.Size(200, 27);
            this.DTFechaFinal.TabIndex = 15;
            this.DTFechaFinal.ValueChanged += new System.EventHandler(this.DTFechaFinal_ValueChanged);
            // 
            // DTFechaInicio
            // 
            this.DTFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaInicio.Location = new System.Drawing.Point(480, 68);
            this.DTFechaInicio.Name = "DTFechaInicio";
            this.DTFechaInicio.Size = new System.Drawing.Size(200, 27);
            this.DTFechaInicio.TabIndex = 14;
            this.DTFechaInicio.ValueChanged += new System.EventHandler(this.DTFechaInicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Inicio:";
            // 
            // txtTEPmin
            // 
            this.txtTEPmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEPmin.Location = new System.Drawing.Point(607, 16);
            this.txtTEPmin.Name = "txtTEPmin";
            this.txtTEPmin.Size = new System.Drawing.Size(97, 28);
            this.txtTEPmin.TabIndex = 11;
            this.txtTEPmin.TextChanged += new System.EventHandler(this.txtTEPmin_TextChanged);
            // 
            // comboBoxTEP
            // 
            this.comboBoxTEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTEP.FormattingEnabled = true;
            this.comboBoxTEP.Items.AddRange(new object[] {
            "Tareas",
            "Empleados",
            "Presupuesto\t\t\t\t"});
            this.comboBoxTEP.Location = new System.Drawing.Point(446, 16);
            this.comboBoxTEP.Name = "comboBoxTEP";
            this.comboBoxTEP.Size = new System.Drawing.Size(155, 28);
            this.comboBoxTEP.TabIndex = 10;
            this.comboBoxTEP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTEP_SelectedIndexChanged);
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
            // comboBoxOrdenaEstado
            // 
            this.comboBoxOrdenaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenaEstado.FormattingEnabled = true;
            this.comboBoxOrdenaEstado.Items.AddRange(new object[] {
            "En curso",
            "Finalizado",
            "Por empezar",
            "Pausado"});
            this.comboBoxOrdenaEstado.Location = new System.Drawing.Point(115, 104);
            this.comboBoxOrdenaEstado.Name = "comboBoxOrdenaEstado";
            this.comboBoxOrdenaEstado.Size = new System.Drawing.Size(155, 28);
            this.comboBoxOrdenaEstado.TabIndex = 8;
            this.comboBoxOrdenaEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenaEstado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            // 
            // textBoxBuscarCategoria
            // 
            this.textBoxBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarCategoria.Location = new System.Drawing.Point(115, 62);
            this.textBoxBuscarCategoria.Name = "textBoxBuscarCategoria";
            this.textBoxBuscarCategoria.Size = new System.Drawing.Size(151, 28);
            this.textBoxBuscarCategoria.TabIndex = 6;
            this.textBoxBuscarCategoria.TextChanged += new System.EventHandler(this.textBoxBuscarCategoria_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(100, 21);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(166, 27);
            this.txtNombreBuscar.TabIndex = 4;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            // 
            // lblProyectoVer
            // 
            this.lblProyectoVer.AutoSize = true;
            this.lblProyectoVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectoVer.Location = new System.Drawing.Point(317, 457);
            this.lblProyectoVer.Name = "lblProyectoVer";
            this.lblProyectoVer.Size = new System.Drawing.Size(273, 29);
            this.lblProyectoVer.TabIndex = 17;
            this.lblProyectoVer.Text = "ID Proyecto:    , Nombre:";
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.Location = new System.Drawing.Point(218, 507);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Size = new System.Drawing.Size(126, 46);
            this.btnVerTareas.TabIndex = 18;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = true;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // btnEditarProyecto
            // 
            this.btnEditarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProyecto.Location = new System.Drawing.Point(392, 507);
            this.btnEditarProyecto.Name = "btnEditarProyecto";
            this.btnEditarProyecto.Size = new System.Drawing.Size(150, 46);
            this.btnEditarProyecto.TabIndex = 19;
            this.btnEditarProyecto.Text = "Editar";
            this.btnEditarProyecto.UseVisualStyleBackColor = true;
            this.btnEditarProyecto.Click += new System.EventHandler(this.btnEditarProyecto_Click);
            // 
            // btnElimarProyecto
            // 
            this.btnElimarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimarProyecto.Location = new System.Drawing.Point(569, 507);
            this.btnElimarProyecto.Name = "btnElimarProyecto";
            this.btnElimarProyecto.Size = new System.Drawing.Size(150, 46);
            this.btnElimarProyecto.TabIndex = 20;
            this.btnElimarProyecto.Text = "Eliminar ";
            this.btnElimarProyecto.UseVisualStyleBackColor = true;
            this.btnElimarProyecto.Click += new System.EventHandler(this.btnElimarProyecto_Click);
            // 
            // btnEditarTaea
            // 
            this.btnEditarTaea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTaea.Location = new System.Drawing.Point(39, 507);
            this.btnEditarTaea.Name = "btnEditarTaea";
            this.btnEditarTaea.Size = new System.Drawing.Size(126, 46);
            this.btnEditarTaea.TabIndex = 21;
            this.btnEditarTaea.Text = "Editar Tarea";
            this.btnEditarTaea.UseVisualStyleBackColor = true;
            this.btnEditarTaea.Click += new System.EventHandler(this.btnEditarTaea_Click);
            // 
            // btnVerDescripcion
            // 
            this.btnVerDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDescripcion.Location = new System.Drawing.Point(756, 507);
            this.btnVerDescripcion.Name = "btnVerDescripcion";
            this.btnVerDescripcion.Size = new System.Drawing.Size(169, 46);
            this.btnVerDescripcion.TabIndex = 22;
            this.btnVerDescripcion.Text = "Ver Descripcion";
            this.btnVerDescripcion.UseVisualStyleBackColor = true;
            this.btnVerDescripcion.Click += new System.EventHandler(this.btnVerDescripcion_Click);
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.btnVerDescripcion);
            this.Controls.Add(this.btnEditarTaea);
            this.Controls.Add(this.btnElimarProyecto);
            this.Controls.Add(this.btnEditarProyecto);
            this.Controls.Add(this.btnVerTareas);
            this.Controls.Add(this.lblProyectoVer);
            this.Controls.Add(this.grpboxBuscarProyectos);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.menuStripProyectos);
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
        private System.Windows.Forms.TextBox txtTEPmin;
        private System.Windows.Forms.DateTimePicker DTFechaFinal;
        private System.Windows.Forms.DateTimePicker DTFechaInicio;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.Label lblProyectoVer;
        private System.Windows.Forms.Button btnVerTareas;
        private System.Windows.Forms.Button btnEditarProyecto;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.TextBox txtTEPmax;
        private System.Windows.Forms.Button btnElimarProyecto;
        private System.Windows.Forms.Button btnEditarTaea;
        private System.Windows.Forms.Button btnVerDescripcion;
    }
}