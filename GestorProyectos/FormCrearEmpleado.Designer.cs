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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCrearEmplPasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrearEmplSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadiendo Empleado...";
            // 
            // txtCrearEmplName
            // 
            this.txtCrearEmplName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplName.Location = new System.Drawing.Point(104, 56);
            this.txtCrearEmplName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCrearEmplName.Name = "txtCrearEmplName";
            this.txtCrearEmplName.Size = new System.Drawing.Size(137, 23);
            this.txtCrearEmplName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña:";
            // 
            // txtCrearEmplPasswd
            // 
            this.txtCrearEmplPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplPasswd.Location = new System.Drawing.Point(104, 94);
            this.txtCrearEmplPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCrearEmplPasswd.Name = "txtCrearEmplPasswd";
            this.txtCrearEmplPasswd.Size = new System.Drawing.Size(137, 23);
            this.txtCrearEmplPasswd.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // txtCrearEmplSalario
            // 
            this.txtCrearEmplSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplSalario.Location = new System.Drawing.Point(104, 140);
            this.txtCrearEmplSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCrearEmplSalario.Name = "txtCrearEmplSalario";
            this.txtCrearEmplSalario.Size = new System.Drawing.Size(137, 23);
            this.txtCrearEmplSalario.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Salario:";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(298, 130);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(150, 43);
            this.btnCrearEmpleado.TabIndex = 25;
            this.btnCrearEmpleado.Text = "Añadir Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(246, 61);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(89, 17);
            this.cbAdmin.TabIndex = 26;
            this.cbAdmin.Text = "Administrador";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // FormCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 189);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.txtCrearEmplSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCrearEmplName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCrearEmplPasswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCrearEmpleado";
            this.Text = "Crear Empleado";
            this.Load += new System.EventHandler(this.FormCrearEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrearEmplName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrearEmplPasswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrearEmplSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}