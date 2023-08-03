
namespace ICEBERG.Presentacion.Vistas.Pedido
{
    partial class Nuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.txtApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.rbMayor = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLineaDePedidos = new System.Windows.Forms.Button();
            this.btnFinalizarLineaDePedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido N°";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Location = new System.Drawing.Point(73, 9);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listado de Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 117);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(447, 96);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Enabled = false;
            this.txtDescripción.Location = new System.Drawing.Point(15, 245);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(447, 20);
            this.txtDescripción.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Enabled = false;
            this.txtPrecioCosto.Location = new System.Drawing.Point(85, 275);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(79, 20);
            this.txtPrecioCosto.TabIndex = 7;
            // 
            // txtPrecioPedido
            // 
            this.txtPrecioPedido.Enabled = false;
            this.txtPrecioPedido.Location = new System.Drawing.Point(243, 275);
            this.txtPrecioPedido.Name = "txtPrecioPedido";
            this.txtPrecioPedido.Size = new System.Drawing.Size(79, 20);
            this.txtPrecioPedido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Pedido";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(383, 275);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripción,
            this.preciocosto,
            this.preciopedido,
            this.cantidad,
            this.subtotalcosto,
            this.subtotalpedido});
            this.dataGridView2.Location = new System.Drawing.Point(15, 341);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(447, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "DESCRIPCIÓN";
            this.Descripción.Name = "Descripción";
            // 
            // preciocosto
            // 
            this.preciocosto.HeaderText = "PRECIO COSTO";
            this.preciocosto.Name = "preciocosto";
            // 
            // preciopedido
            // 
            this.preciopedido.HeaderText = "PRECIO PEDIDO";
            this.preciopedido.Name = "preciopedido";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // subtotalcosto
            // 
            this.subtotalcosto.HeaderText = "SUBTOTAL - COSTO";
            this.subtotalcosto.Name = "subtotalcosto";
            // 
            // subtotalpedido
            // 
            this.subtotalpedido.HeaderText = "SUBTOTAL - PEDIDO";
            this.subtotalpedido.Name = "subtotalpedido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(96, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Costo";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(383, 507);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(383, 533);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(79, 20);
            this.txtCosto.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 507);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Buscar Cliente por Dni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Atendido por";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(243, 9);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(219, 20);
            this.txtEmpleado.TabIndex = 23;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(133, 42);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(110, 21);
            this.cboClientes.TabIndex = 24;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // txtApellidoyNombre
            // 
            this.txtApellidoyNombre.Enabled = false;
            this.txtApellidoyNombre.Location = new System.Drawing.Point(61, 72);
            this.txtApellidoyNombre.Name = "txtApellidoyNombre";
            this.txtApellidoyNombre.Size = new System.Drawing.Size(404, 20);
            this.txtApellidoyNombre.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cliente";
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Location = new System.Drawing.Point(270, 45);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(55, 17);
            this.rbMenor.TabIndex = 27;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // rbMayor
            // 
            this.rbMayor.AutoSize = true;
            this.rbMayor.Location = new System.Drawing.Point(349, 46);
            this.rbMayor.Name = "rbMayor";
            this.rbMayor.Size = new System.Drawing.Size(54, 17);
            this.rbMayor.TabIndex = 28;
            this.rbMayor.TabStop = true;
            this.rbMayor.Text = "Mayor";
            this.rbMayor.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(383, 312);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // btnLineaDePedidos
            // 
            this.btnLineaDePedidos.Location = new System.Drawing.Point(15, 537);
            this.btnLineaDePedidos.Name = "btnLineaDePedidos";
            this.btnLineaDePedidos.Size = new System.Drawing.Size(130, 23);
            this.btnLineaDePedidos.TabIndex = 30;
            this.btnLineaDePedidos.Text = "Ver Lineas de Pedidos";
            this.btnLineaDePedidos.UseVisualStyleBackColor = true;
            this.btnLineaDePedidos.Click += new System.EventHandler(this.btnLineaDePedidos_Click);
            // 
            // btnFinalizarLineaDePedidos
            // 
            this.btnFinalizarLineaDePedidos.Location = new System.Drawing.Point(151, 537);
            this.btnFinalizarLineaDePedidos.Name = "btnFinalizarLineaDePedidos";
            this.btnFinalizarLineaDePedidos.Size = new System.Drawing.Size(156, 23);
            this.btnFinalizarLineaDePedidos.TabIndex = 31;
            this.btnFinalizarLineaDePedidos.Text = "Finalizar Linea De Pedidos";
            this.btnFinalizarLineaDePedidos.UseVisualStyleBackColor = true;
            this.btnFinalizarLineaDePedidos.Click += new System.EventHandler(this.btnFinalizarLineaDePedidos_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 579);
            this.Controls.Add(this.btnFinalizarLineaDePedidos);
            this.Controls.Add(this.btnLineaDePedidos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.rbMayor);
            this.Controls.Add(this.rbMenor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtApellidoyNombre);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label1);
            this.Name = "Nuevo";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPrecioCosto;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCosto;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDescripción;
        public System.Windows.Forms.TextBox txtEmpleado;
        public System.Windows.Forms.ComboBox cboClientes;
        public System.Windows.Forms.TextBox txtNumeroPedido;
        public System.Windows.Forms.DataGridView dgvArticulos;
        public System.Windows.Forms.TextBox txtPrecioPedido;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txtApellidoyNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.RadioButton rbMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalpedido;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Button btnLineaDePedidos;
        public System.Windows.Forms.Button btnFinalizarLineaDePedidos;
    }
}