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
            this.components = new System.ComponentModel.Container();
            this.btnHomeLinkEmpleados = new System.Windows.Forms.Button();
            this.btnHomeLinkProyectos = new System.Windows.Forms.Button();
            this.lblFechaHome = new System.Windows.Forms.Label();
            this.lblHoraHome = new System.Windows.Forms.Label();
            this.timerHome = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnHomeLinkEmpleados
            // 
            this.btnHomeLinkEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkEmpleados.Location = new System.Drawing.Point(355, 183);
            this.btnHomeLinkEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeLinkEmpleados.Name = "btnHomeLinkEmpleados";
            this.btnHomeLinkEmpleados.Size = new System.Drawing.Size(170, 110);
            this.btnHomeLinkEmpleados.TabIndex = 10;
            this.btnHomeLinkEmpleados.Text = "Tus \r\ncolaboradores\r\n";
            this.btnHomeLinkEmpleados.UseVisualStyleBackColor = true;
            this.btnHomeLinkEmpleados.Click += new System.EventHandler(this.btnHomeLinkEmpleados_Click);
            // 
            // btnHomeLinkProyectos
            // 
            this.btnHomeLinkProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLinkProyectos.Location = new System.Drawing.Point(157, 183);
            this.btnHomeLinkProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeLinkProyectos.Name = "btnHomeLinkProyectos";
            this.btnHomeLinkProyectos.Size = new System.Drawing.Size(175, 110);
            this.btnHomeLinkProyectos.TabIndex = 9;
            this.btnHomeLinkProyectos.Text = "Tus \r\nproyectos";
            this.btnHomeLinkProyectos.UseVisualStyleBackColor = true;
            this.btnHomeLinkProyectos.Click += new System.EventHandler(this.btnHomeLinkProyectos_Click);
            // 
            // lblFechaHome
            // 
            this.lblFechaHome.AutoSize = true;
            this.lblFechaHome.BackColor = System.Drawing.Color.GreenYellow;
            this.lblFechaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHome.Location = new System.Drawing.Point(308, 81);
            this.lblFechaHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHome.Name = "lblFechaHome";
            this.lblFechaHome.Size = new System.Drawing.Size(15, 24);
            this.lblFechaHome.TabIndex = 8;
            this.lblFechaHome.Text = " ";
            this.lblFechaHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFechaHome.Click += new System.EventHandler(this.lblFechaHome_Click);
            // 
            // lblHoraHome
            // 
            this.lblHoraHome.AutoSize = true;
            this.lblHoraHome.BackColor = System.Drawing.Color.GreenYellow;
            this.lblHoraHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraHome.Location = new System.Drawing.Point(305, 34);
            this.lblHoraHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraHome.Name = "lblHoraHome";
            this.lblHoraHome.Size = new System.Drawing.Size(27, 37);
            this.lblHoraHome.TabIndex = 7;
            this.lblHoraHome.Text = " ";
            this.lblHoraHome.Click += new System.EventHandler(this.lblHoraHome_Click);
            // 
            // timerHome
            // 
            this.timerHome.Interval = 1;
            this.timerHome.Tick += new System.EventHandler(this.timerHome_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.btnHomeLinkEmpleados);
            this.Controls.Add(this.btnHomeLinkProyectos);
            this.Controls.Add(this.lblFechaHome);
            this.Controls.Add(this.lblHoraHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHomeLinkEmpleados;
        private System.Windows.Forms.Button btnHomeLinkProyectos;
        private System.Windows.Forms.Label lblFechaHome;
        private System.Windows.Forms.Label lblHoraHome;
        private System.Windows.Forms.Timer timerHome;
    }
}