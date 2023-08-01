
namespace ICEBERG.Presentacion.Vistas.Proveedor
{
    partial class Inicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.razonsocial,
            this.cuit,
            this.cuil,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.CorreoElectronico,
            this.TelefonoFijo,
            this.Celular});
            this.dataGridView1.Location = new System.Drawing.Point(15, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Proveedores";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(870, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(870, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(870, 42);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "Identifacador";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Visible = false;
            // 
            // razonsocial
            // 
            this.razonsocial.DataPropertyName = "razonsocial";
            this.razonsocial.HeaderText = "Razón Social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // cuil
            // 
            this.cuil.DataPropertyName = "cuil";
            this.cuil.HeaderText = "Cuil";
            this.cuil.Name = "cuil";
            this.cuil.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.CorreoElectronico.HeaderText = "Correo Electronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            // 
            // TelefonoFijo
            // 
            this.TelefonoFijo.DataPropertyName = "TelefonoFijo";
            this.TelefonoFijo.HeaderText = "Telefono Fijo";
            this.TelefonoFijo.Name = "TelefonoFijo";
            this.TelefonoFijo.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 209);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicio";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        public System.Windows.Forms.BindingSource bindingSource1;
    }
}