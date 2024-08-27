namespace GestorProyectos
{
    partial class FormCrearEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrearEmplName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.txtCrearEmplPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadiendo Empleado...";
            // 
            // txtCrearEmplName
            // 
            this.txtCrearEmplName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplName.Location = new System.Drawing.Point(113, 59);
            this.txtCrearEmplName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearEmplName.Name = "txtCrearEmplName";
            this.txtCrearEmplName.Size = new System.Drawing.Size(137, 23);
            this.txtCrearEmplName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(260, 132);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(153, 43);
            this.btnCrearEmpleado.TabIndex = 25;
            this.btnCrearEmpleado.Text = "Añadir Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // txtCrearEmplPasswd
            // 
            this.txtCrearEmplPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplPasswd.Location = new System.Drawing.Point(113, 96);
            this.txtCrearEmplPasswd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearEmplPasswd.Name = "txtCrearEmplPasswd";
            this.txtCrearEmplPasswd.Size = new System.Drawing.Size(137, 23);
            this.txtCrearEmplPasswd.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña:";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(259, 63);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(104, 17);
            this.cbAdmin.TabIndex = 28;
            this.cbAdmin.Text = "Es Administrador";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // FormCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(424, 186);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.txtCrearEmplPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.txtCrearEmplName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCrearEmpleado";
            this.Text = "FormCrearEmpleado";
            this.Load += new System.EventHandler(this.FormCrearEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrearEmplName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.TextBox txtCrearEmplPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}