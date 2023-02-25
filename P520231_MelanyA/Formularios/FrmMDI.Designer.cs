namespace P520231_MelanyA.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoríasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpresiónDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registroDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.MistyRose;
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MnuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReportes,
            this.MnuSalir,
            this.MnuAcercaDe});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(782, 40);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestiónDeProductosToolStripMenuItem,
            this.gestiónDeProveedoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoríasDeProductosToolStripMenuItem,
            this.rolesDeUsuariosToolStripMenuItem,
            this.tiposDeProveedorToolStripMenuItem,
            this.tiposDeCompraToolStripMenuItem,
            this.toolStripSeparator4});
            this.MnuGestiones.ForeColor = System.Drawing.Color.DarkBlue;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(151, 36);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCompraToolStripMenuItem,
            this.toolStripSeparator3});
            this.MnuProcesos.ForeColor = System.Drawing.Color.DarkBlue;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(146, 36);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorFechasToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.comprasPorProductosToolStripMenuItem,
            this.listadoDeInventarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.reimpresiónDeCompraToolStripMenuItem});
            this.MnuReportes.ForeColor = System.Drawing.Color.DarkBlue;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(138, 36);
            this.MnuReportes.Text = "REPORTES";
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.Color.DarkBlue;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(89, 36);
            this.MnuSalir.Text = "SALIR";
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(134, 36);
            this.MnuAcercaDe.Text = "Acerca de";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            // 
            // gestiónDeProductosToolStripMenuItem
            // 
            this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
            this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de productos";
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            this.gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            this.gestiónDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de proveedores";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(375, 6);
            // 
            // categoríasDeProductosToolStripMenuItem
            // 
            this.categoríasDeProductosToolStripMenuItem.Name = "categoríasDeProductosToolStripMenuItem";
            this.categoríasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.categoríasDeProductosToolStripMenuItem.Text = "Categorías de productos";
            // 
            // rolesDeUsuariosToolStripMenuItem
            // 
            this.rolesDeUsuariosToolStripMenuItem.Name = "rolesDeUsuariosToolStripMenuItem";
            this.rolesDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.rolesDeUsuariosToolStripMenuItem.Text = "Roles de usuarios";
            // 
            // tiposDeProveedorToolStripMenuItem
            // 
            this.tiposDeProveedorToolStripMenuItem.Name = "tiposDeProveedorToolStripMenuItem";
            this.tiposDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.tiposDeProveedorToolStripMenuItem.Text = "Tipos de proveedor";
            // 
            // tiposDeCompraToolStripMenuItem
            // 
            this.tiposDeCompraToolStripMenuItem.Name = "tiposDeCompraToolStripMenuItem";
            this.tiposDeCompraToolStripMenuItem.Size = new System.Drawing.Size(378, 40);
            this.tiposDeCompraToolStripMenuItem.Text = "Tipos de compra";
            // 
            // comprasPorFechasToolStripMenuItem
            // 
            this.comprasPorFechasToolStripMenuItem.Name = "comprasPorFechasToolStripMenuItem";
            this.comprasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(372, 40);
            this.comprasPorFechasToolStripMenuItem.Text = "Compras por fechas";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(372, 40);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por proveedor";
            // 
            // comprasPorProductosToolStripMenuItem
            // 
            this.comprasPorProductosToolStripMenuItem.Name = "comprasPorProductosToolStripMenuItem";
            this.comprasPorProductosToolStripMenuItem.Size = new System.Drawing.Size(372, 40);
            this.comprasPorProductosToolStripMenuItem.Text = "Compras por productos";
            // 
            // listadoDeInventarioToolStripMenuItem
            // 
            this.listadoDeInventarioToolStripMenuItem.Name = "listadoDeInventarioToolStripMenuItem";
            this.listadoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(372, 40);
            this.listadoDeInventarioToolStripMenuItem.Text = "Listado de inventario";
            // 
            // reimpresiónDeCompraToolStripMenuItem
            // 
            this.reimpresiónDeCompraToolStripMenuItem.Name = "reimpresiónDeCompraToolStripMenuItem";
            this.reimpresiónDeCompraToolStripMenuItem.Size = new System.Drawing.Size(372, 40);
            this.reimpresiónDeCompraToolStripMenuItem.Text = "Reimpresión de compra";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(369, 6);
            // 
            // registroDeCompraToolStripMenuItem
            // 
            this.registroDeCompraToolStripMenuItem.Name = "registroDeCompraToolStripMenuItem";
            this.registroDeCompraToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.registroDeCompraToolStripMenuItem.Text = "Registro de compra";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(322, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(375, 6);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 541);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "SISTEMA DE COMPRAS PROGRA5-2023";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoríasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem registroDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reimpresiónDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
    }
}