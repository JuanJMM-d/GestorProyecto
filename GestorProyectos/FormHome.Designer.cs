namespace GestorProyectos
{
    partial class FormHome
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
            this.btnHomeLinkGraficos = new System.Windows.Forms.Button();
            this.btnHomeLinkBuzon = new System.Windows.Forms.Button();
            this.btnHomeLinkEmpleados = new System.Windows.Forms.Button();
            this.btnHomeLinkProyectos = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblHoraHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHomeLinkGraficos
            // 
            this.btnHomeLinkGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkGraficos.Location = new System.Drawing.Point(482, 326);
            this.btnHomeLinkGraficos.Name = "btnHomeLinkGraficos";
            this.btnHomeLinkGraficos.Size = new System.Drawing.Size(227, 136);
            this.btnHomeLinkGraficos.TabIndex = 12;
            this.btnHomeLinkGraficos.Text = "Tu \r\nseguimiento\r\n📊";
            this.btnHomeLinkGraficos.UseVisualStyleBackColor = true;
            // 
            // btnHomeLinkBuzon
            // 
            this.btnHomeLinkBuzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkBuzon.Location = new System.Drawing.Point(224, 326);
            this.btnHomeLinkBuzon.Name = "btnHomeLinkBuzon";
            this.btnHomeLinkBuzon.Size = new System.Drawing.Size(227, 136);
            this.btnHomeLinkBuzon.TabIndex = 11;
            this.btnHomeLinkBuzon.Text = "Tus \r\nnotificaciones\r\n(Buzon)";
            this.btnHomeLinkBuzon.UseVisualStyleBackColor = true;
            // 
            // btnHomeLinkEmpleados
            // 
            this.btnHomeLinkEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkEmpleados.Location = new System.Drawing.Point(482, 169);
            this.btnHomeLinkEmpleados.Name = "btnHomeLinkEmpleados";
            this.btnHomeLinkEmpleados.Size = new System.Drawing.Size(227, 136);
            this.btnHomeLinkEmpleados.TabIndex = 10;
            this.btnHomeLinkEmpleados.Text = "Tus \r\ncolaboradores\r\n";
            this.btnHomeLinkEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnHomeLinkProyectos
            // 
            this.btnHomeLinkProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkProyectos.Location = new System.Drawing.Point(218, 169);
            this.btnHomeLinkProyectos.Name = "btnHomeLinkProyectos";
            this.btnHomeLinkProyectos.Size = new System.Drawing.Size(233, 136);
            this.btnHomeLinkProyectos.TabIndex = 9;
            this.btnHomeLinkProyectos.Text = "Tus \r\nproyectos";
            this.btnHomeLinkProyectos.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(410, 100);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(108, 29);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "fecaha....";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHoraHome
            // 
            this.lblHoraHome.AutoSize = true;
            this.lblHoraHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraHome.Location = new System.Drawing.Point(407, 42);
            this.lblHoraHome.Name = "lblHoraHome";
            this.lblHoraHome.Size = new System.Drawing.Size(152, 46);
            this.lblHoraHome.TabIndex = 7;
            this.lblHoraHome.Text = "hora....";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.btnHomeLinkGraficos);
            this.Controls.Add(this.btnHomeLinkBuzon);
            this.Controls.Add(this.btnHomeLinkEmpleados);
            this.Controls.Add(this.btnHomeLinkProyectos);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblHoraHome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomeLinkGraficos;
        private System.Windows.Forms.Button btnHomeLinkBuzon;
        private System.Windows.Forms.Button btnHomeLinkEmpleados;
        private System.Windows.Forms.Button btnHomeLinkProyectos;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblHoraHome;
    }
}