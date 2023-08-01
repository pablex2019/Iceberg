
namespace ICEBERG.Presentacion.Vistas.Usuario
{
    partial class Editar
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDnis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Perfil";
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(15, 149);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(210, 21);
            this.cboPerfiles.TabIndex = 54;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(15, 108);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(210, 20);
            this.txtLegajo.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Legajo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 190);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtUsuario.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(15, 228);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(210, 20);
            this.txtClave.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Contraseña";
            // 
            // txtApellidoyNombre
            // 
            this.txtApellidoyNombre.Location = new System.Drawing.Point(15, 66);
            this.txtApellidoyNombre.Name = "txtApellidoyNombre";
            this.txtApellidoyNombre.ReadOnly = true;
            this.txtApellidoyNombre.Size = new System.Drawing.Size(210, 20);
            this.txtApellidoyNombre.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Apellido y Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Dni";
            // 
            // cboDnis
            // 
            this.cboDnis.FormattingEnabled = true;
            this.cboDnis.Location = new System.Drawing.Point(15, 25);
            this.cboDnis.Name = "cboDnis";
            this.cboDnis.Size = new System.Drawing.Size(210, 21);
            this.cboDnis.TabIndex = 56;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 298);
            this.Controls.Add(this.txtApellidoyNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDnis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPerfiles);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Editar";
            this.Text = "Usuario - Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cboPerfiles;
        public System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtApellidoyNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboDnis;
    }
}