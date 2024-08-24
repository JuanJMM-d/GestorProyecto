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
            this.txtCrearEmplID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCrearEmplNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrearEmplSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadiendo Empleado...";
            // 
            // txtCrearEmplID
            // 
            this.txtCrearEmplID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplID.Location = new System.Drawing.Point(110, 73);
            this.txtCrearEmplID.Name = "txtCrearEmplID";
            this.txtCrearEmplID.Size = new System.Drawing.Size(181, 27);
            this.txtCrearEmplID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // txtCrearEmplNombre
            // 
            this.txtCrearEmplNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplNombre.Location = new System.Drawing.Point(110, 119);
            this.txtCrearEmplNombre.Name = "txtCrearEmplNombre";
            this.txtCrearEmplNombre.Size = new System.Drawing.Size(181, 27);
            this.txtCrearEmplNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // txtCrearEmplSalario
            // 
            this.txtCrearEmplSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmplSalario.Location = new System.Drawing.Point(110, 183);
            this.txtCrearEmplSalario.Name = "txtCrearEmplSalario";
            this.txtCrearEmplSalario.Size = new System.Drawing.Size(181, 27);
            this.txtCrearEmplSalario.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Salario:";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(380, 157);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(181, 53);
            this.btnCrearEmpleado.TabIndex = 25;
            this.btnCrearEmpleado.Text = "Añadir Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // FormCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 265);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.txtCrearEmplSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCrearEmplID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCrearEmplNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearEmpleado";
            this.Text = "FormCrearEmpleado";
            this.Load += new System.EventHandler(this.FormCrearEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrearEmplID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrearEmplNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrearEmplSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearEmpleado;
    }
}