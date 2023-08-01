
namespace ICEBERG.Presentacion.Vistas.Articulo
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciopedidopormenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciopedidopormayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(757, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(757, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(757, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Listado de Articulos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.Codigo,
            this.descripción,
            this.preciocosto,
            this.preciopedidopormenor,
            this.preciopedidopormayor,
            this.categoria});
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(726, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "EmpleadoId";
            this.ClienteId.HeaderText = "Identifacador";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // descripción
            // 
            this.descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripción.DataPropertyName = "descripción";
            this.descripción.HeaderText = "Descripción";
            this.descripción.Name = "descripción";
            this.descripción.ReadOnly = true;
            // 
            // preciocosto
            // 
            this.preciocosto.DataPropertyName = "preciocosto";
            this.preciocosto.HeaderText = "Precio Costo";
            this.preciocosto.Name = "preciocosto";
            this.preciocosto.ReadOnly = true;
            // 
            // preciopedidopormenor
            // 
            this.preciopedidopormenor.DataPropertyName = "preciopedidopormenor";
            this.preciopedidopormenor.HeaderText = "Precio Pedido Por Menor";
            this.preciopedidopormenor.Name = "preciopedidopormenor";
            this.preciopedidopormenor.ReadOnly = true;
            // 
            // preciopedidopormayor
            // 
            this.preciopedidopormayor.DataPropertyName = "preciopedidopormayor";
            this.preciopedidopormayor.HeaderText = "Precio Pedido Por Mayor";
            this.preciopedidopormayor.Name = "preciopedidopormayor";
            this.preciopedidopormayor.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 209);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicio";
            this.Text = "Articulos - Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciopedidopormenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciopedidopormayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}