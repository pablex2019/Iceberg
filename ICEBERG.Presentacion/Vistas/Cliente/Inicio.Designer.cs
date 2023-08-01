
namespace ICEBERG.Presentacion.Vistas.Cliente
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDeudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.NombresCliente,
            this.Apellidos,
            this.Domicilio,
            this.DNI,
            this.TelefonoFijo,
            this.Celular,
            this.CorreoElectronico,
            this.SaldoDeudor});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(860, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Clientes";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(860, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(860, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "Identifacador";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Visible = false;
            // 
            // NombresCliente
            // 
            this.NombresCliente.DataPropertyName = "Nombre";
            this.NombresCliente.HeaderText = "Nombre";
            this.NombresCliente.Name = "NombresCliente";
            this.NombresCliente.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellido";
            this.Apellidos.HeaderText = "Apellido";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
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
            // CorreoElectronico
            // 
            this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.CorreoElectronico.HeaderText = "Correo Electronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            // 
            // SaldoDeudor
            // 
            this.SaldoDeudor.DataPropertyName = "SaldoDeudor";
            this.SaldoDeudor.HeaderText = "Saldo Deudor";
            this.SaldoDeudor.Name = "SaldoDeudor";
            this.SaldoDeudor.ReadOnly = true;
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(949, 206);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDeudor;
    }
}