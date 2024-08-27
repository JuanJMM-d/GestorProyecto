namespace GestorProyectos
{
    partial class FormChat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDestinatario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMensaje = new System.Windows.Forms.TextBox();
            this.txbChat = new System.Windows.Forms.RichTextBox();
            this.datosUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosUsuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txbChat);
            this.groupBox1.Controls.Add(this.cbDestinatario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMensaje);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // cbDestinatario
            // 
            this.cbDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinatario.FormattingEnabled = true;
            this.cbDestinatario.Location = new System.Drawing.Point(12, 19);
            this.cbDestinatario.Name = "cbDestinatario";
            this.cbDestinatario.Size = new System.Drawing.Size(354, 21);
            this.cbDestinatario.TabIndex = 4;
            this.cbDestinatario.SelectedIndexChanged += new System.EventHandler(this.cbDestinatario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Presiona enter para enviar";
            // 
            // txbMensaje
            // 
            this.txbMensaje.Location = new System.Drawing.Point(6, 376);
            this.txbMensaje.Name = "txbMensaje";
            this.txbMensaje.Size = new System.Drawing.Size(366, 20);
            this.txbMensaje.TabIndex = 2;
            this.txbMensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMensaje_KeyUp);
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(6, 46);
            this.txbChat.Name = "txbChat";
            this.txbChat.ReadOnly = true;
            this.txbChat.Size = new System.Drawing.Size(366, 311);
            this.txbChat.TabIndex = 5;
            this.txbChat.Text = "";
            // 
            // datosUsuariosBindingSource
            // 
            this.datosUsuariosBindingSource.DataSource = typeof(GestorProyectos.Code.Users.DatosUsuarios);
            // 
            // datosUsuariosBindingSource1
            // 
            this.datosUsuariosBindingSource1.DataSource = typeof(GestorProyectos.Code.Users.DatosUsuarios);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMensaje;
        private System.Windows.Forms.ComboBox cbDestinatario;
        private System.Windows.Forms.RichTextBox txbChat;
        private System.Windows.Forms.BindingSource datosUsuariosBindingSource1;
        private System.Windows.Forms.BindingSource datosUsuariosBindingSource;
    }
}