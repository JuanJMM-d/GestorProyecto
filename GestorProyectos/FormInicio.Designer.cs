namespace GestorProyectos
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panelMenuIzq = new System.Windows.Forms.Panel();
            this.btnProyectosLista = new System.Windows.Forms.Button();
            this.btnMenuGraficos = new System.Windows.Forms.Button();
            this.btnMenuBuzon = new System.Windows.Forms.Button();
            this.btnMenuEmpleados = new System.Windows.Forms.Button();
            this.btnCrearProycto = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.picturePerfilAdmin = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblMenuActual = new System.Windows.Forms.Label();
            this.panelMenuSeleccionado = new System.Windows.Forms.Panel();
            this.panelMenuIzq.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfilAdmin)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuIzq
            // 
            this.panelMenuIzq.Controls.Add(this.btnProyectosLista);
            this.panelMenuIzq.Controls.Add(this.btnMenuGraficos);
            this.panelMenuIzq.Controls.Add(this.btnMenuBuzon);
            this.panelMenuIzq.Controls.Add(this.btnMenuEmpleados);
            this.panelMenuIzq.Controls.Add(this.btnCrearProycto);
            this.panelMenuIzq.Controls.Add(this.btnHome);
            this.panelMenuIzq.Controls.Add(this.panelPerfil);
            this.panelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzq.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzq.Name = "panelMenuIzq";
            this.panelMenuIzq.Size = new System.Drawing.Size(270, 662);
            this.panelMenuIzq.TabIndex = 0;
            // 
            // btnProyectosLista
            // 
            this.btnProyectosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectosLista.Location = new System.Drawing.Point(29, 273);
            this.btnProyectosLista.Name = "btnProyectosLista";
            this.btnProyectosLista.Size = new System.Drawing.Size(175, 48);
            this.btnProyectosLista.TabIndex = 6;
            this.btnProyectosLista.Text = " 📂 Proyectos";
            this.btnProyectosLista.UseVisualStyleBackColor = true;
            this.btnProyectosLista.Click += new System.EventHandler(this.btnProyectosLista_Click);
            // 
            // btnMenuGraficos
            // 
            this.btnMenuGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGraficos.Location = new System.Drawing.Point(29, 487);
            this.btnMenuGraficos.Name = "btnMenuGraficos";
            this.btnMenuGraficos.Size = new System.Drawing.Size(193, 48);
            this.btnMenuGraficos.TabIndex = 5;
            this.btnMenuGraficos.Text = "📉 Graficos..";
            this.btnMenuGraficos.UseVisualStyleBackColor = true;
            // 
            // btnMenuBuzon
            // 
            this.btnMenuBuzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBuzon.Location = new System.Drawing.Point(29, 412);
            this.btnMenuBuzon.Name = "btnMenuBuzon";
            this.btnMenuBuzon.Size = new System.Drawing.Size(193, 48);
            this.btnMenuBuzon.TabIndex = 4;
            this.btnMenuBuzon.Text = "📫 Buzon";
            this.btnMenuBuzon.UseVisualStyleBackColor = true;
            // 
            // btnMenuEmpleados
            // 
            this.btnMenuEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEmpleados.Location = new System.Drawing.Point(29, 337);
            this.btnMenuEmpleados.Name = "btnMenuEmpleados";
            this.btnMenuEmpleados.Size = new System.Drawing.Size(193, 48);
            this.btnMenuEmpleados.TabIndex = 3;
            this.btnMenuEmpleados.Text = "👥 Empleados";
            this.btnMenuEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnCrearProycto
            // 
            this.btnCrearProycto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProycto.Location = new System.Drawing.Point(29, 110);
            this.btnCrearProycto.Name = "btnCrearProycto";
            this.btnCrearProycto.Size = new System.Drawing.Size(217, 64);
            this.btnCrearProycto.TabIndex = 2;
            this.btnCrearProycto.Text = "➕ Crear Proyecto";
            this.btnCrearProycto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearProycto.UseVisualStyleBackColor = true;
            this.btnCrearProycto.Click += new System.EventHandler(this.btnCrearProycto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(29, 199);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "🏠 Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelPerfil
            // 
            this.panelPerfil.Controls.Add(this.picturePerfilAdmin);
            this.panelPerfil.Controls.Add(this.lblAdmin);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(270, 73);
            this.panelPerfil.TabIndex = 0;
            // 
            // picturePerfilAdmin
            // 
            this.picturePerfilAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.picturePerfilAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picturePerfilAdmin.Image")));
            this.picturePerfilAdmin.Location = new System.Drawing.Point(0, 0);
            this.picturePerfilAdmin.Name = "picturePerfilAdmin";
            this.picturePerfilAdmin.Size = new System.Drawing.Size(112, 73);
            this.picturePerfilAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfilAdmin.TabIndex = 1;
            this.picturePerfilAdmin.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(116, 28);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 22);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admistrador";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.lblMenuActual);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(270, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(993, 50);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // lblMenuActual
            // 
            this.lblMenuActual.AutoSize = true;
            this.lblMenuActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuActual.Location = new System.Drawing.Point(438, 9);
            this.lblMenuActual.Name = "lblMenuActual";
            this.lblMenuActual.Size = new System.Drawing.Size(201, 32);
            this.lblMenuActual.TabIndex = 0;
            this.lblMenuActual.Text = "menu actual....";
            // 
            // panelMenuSeleccionado
            // 
            this.panelMenuSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuSeleccionado.Location = new System.Drawing.Point(270, 50);
            this.panelMenuSeleccionado.Name = "panelMenuSeleccionado";
            this.panelMenuSeleccionado.Size = new System.Drawing.Size(993, 612);
            this.panelMenuSeleccionado.TabIndex = 2;
            this.panelMenuSeleccionado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuSeleccionado_Paint);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 662);
            this.Controls.Add(this.panelMenuSeleccionado);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenuIzq);
            this.Name = "FormInicio";
            this.Text = "ForrmInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panelMenuIzq.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfilAdmin)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzq;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelMenuSeleccionado;
        private System.Windows.Forms.Label lblMenuActual;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picturePerfilAdmin;
        private System.Windows.Forms.Button btnMenuGraficos;
        private System.Windows.Forms.Button btnMenuBuzon;
        private System.Windows.Forms.Button btnMenuEmpleados;
        private System.Windows.Forms.Button btnCrearProycto;
        private System.Windows.Forms.Button btnProyectosLista;
    }
}