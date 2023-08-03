
namespace ICEBERG.Presentacion.Vistas
{
    partial class PantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRubros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorías = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovedades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArticulos,
            this.mnuRubros,
            this.mnuCategorías,
            this.mnuClientes,
            this.mnuProveedores,
            this.mnuEmpleados,
            this.mnuUsuarios,
            this.mnuNovedades,
            this.mnuPedidos,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArticulos
            // 
            this.mnuArticulos.Name = "mnuArticulos";
            this.mnuArticulos.Size = new System.Drawing.Size(66, 20);
            this.mnuArticulos.Text = "Articulos";
            this.mnuArticulos.Click += new System.EventHandler(this.mnuArticulos_Click);
            // 
            // mnuRubros
            // 
            this.mnuRubros.Name = "mnuRubros";
            this.mnuRubros.Size = new System.Drawing.Size(56, 20);
            this.mnuRubros.Text = "Rubros";
            this.mnuRubros.Click += new System.EventHandler(this.mnuRubros_Click);
            // 
            // mnuCategorías
            // 
            this.mnuCategorías.Name = "mnuCategorías";
            this.mnuCategorías.Size = new System.Drawing.Size(75, 20);
            this.mnuCategorías.Text = "Categorías";
            this.mnuCategorías.Click += new System.EventHandler(this.mnuCategorías_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(61, 20);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuProveedores
            // 
            this.mnuProveedores.Name = "mnuProveedores";
            this.mnuProveedores.Size = new System.Drawing.Size(84, 20);
            this.mnuProveedores.Text = "Proveedores";
            this.mnuProveedores.Click += new System.EventHandler(this.mnuProveedores_Click);
            // 
            // mnuEmpleados
            // 
            this.mnuEmpleados.Name = "mnuEmpleados";
            this.mnuEmpleados.Size = new System.Drawing.Size(77, 20);
            this.mnuEmpleados.Text = "Empleados";
            this.mnuEmpleados.Click += new System.EventHandler(this.mnuEmpleados_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuNovedades
            // 
            this.mnuNovedades.Name = "mnuNovedades";
            this.mnuNovedades.Size = new System.Drawing.Size(78, 20);
            this.mnuNovedades.Text = "Novedades";
            this.mnuNovedades.Click += new System.EventHandler(this.mnuNovedades_Click);
            // 
            // mnuPedidos
            // 
            this.mnuPedidos.Name = "mnuPedidos";
            this.mnuPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnuPedidos.Text = "Pedidos";
            this.mnuPedidos.Click += new System.EventHandler(this.mnuPedidos_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 666);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuArticulos;
        private System.Windows.Forms.ToolStripMenuItem mnuRubros;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorías;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuNovedades;
        private System.Windows.Forms.ToolStripMenuItem mnuPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}