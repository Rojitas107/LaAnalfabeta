namespace LaAnalfabeta
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.aplicacionWebToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoLibroToolStripMenuItem,
            this.nombreLibroToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // codigoLibroToolStripMenuItem
            // 
            this.codigoLibroToolStripMenuItem.Name = "codigoLibroToolStripMenuItem";
            this.codigoLibroToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.codigoLibroToolStripMenuItem.Text = "Codigo Libro";
            this.codigoLibroToolStripMenuItem.Click += new System.EventHandler(this.codigoLibroToolStripMenuItem_Click);
            // 
            // nombreLibroToolStripMenuItem
            // 
            this.nombreLibroToolStripMenuItem.Name = "nombreLibroToolStripMenuItem";
            this.nombreLibroToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.nombreLibroToolStripMenuItem.Text = "Nombre Libro";
            this.nombreLibroToolStripMenuItem.Click += new System.EventHandler(this.nombreLibroToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoLibroToolStripMenuItem,
            this.eliminarUnLibroToolStripMenuItem,
            this.actualizarLibroToolStripMenuItem});
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            // 
            // ingresarNuevoLibroToolStripMenuItem
            // 
            this.ingresarNuevoLibroToolStripMenuItem.Name = "ingresarNuevoLibroToolStripMenuItem";
            this.ingresarNuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresarNuevoLibroToolStripMenuItem.Text = "Ingresar nuevo libro";
            this.ingresarNuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoLibroToolStripMenuItem_Click);
            // 
            // eliminarUnLibroToolStripMenuItem
            // 
            this.eliminarUnLibroToolStripMenuItem.Name = "eliminarUnLibroToolStripMenuItem";
            this.eliminarUnLibroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarUnLibroToolStripMenuItem.Text = "Eliminar un libro";
            this.eliminarUnLibroToolStripMenuItem.Click += new System.EventHandler(this.eliminarUnLibroToolStripMenuItem_Click);
            // 
            // actualizarLibroToolStripMenuItem
            // 
            this.actualizarLibroToolStripMenuItem.Name = "actualizarLibroToolStripMenuItem";
            this.actualizarLibroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actualizarLibroToolStripMenuItem.Text = "Actualizar Libro";
            this.actualizarLibroToolStripMenuItem.Click += new System.EventHandler(this.actualizarLibroToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestarLibroToolStripMenuItem,
            this.reintegrarLibroToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // prestarLibroToolStripMenuItem
            // 
            this.prestarLibroToolStripMenuItem.Name = "prestarLibroToolStripMenuItem";
            this.prestarLibroToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.prestarLibroToolStripMenuItem.Text = "Prestar libro";
            this.prestarLibroToolStripMenuItem.Click += new System.EventHandler(this.prestarLibroToolStripMenuItem_Click);
            // 
            // reintegrarLibroToolStripMenuItem
            // 
            this.reintegrarLibroToolStripMenuItem.Name = "reintegrarLibroToolStripMenuItem";
            this.reintegrarLibroToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.reintegrarLibroToolStripMenuItem.Text = "Reintegrar libro";
            this.reintegrarLibroToolStripMenuItem.Click += new System.EventHandler(this.reintegrarLibroToolStripMenuItem_Click);
            // 
            // aplicacionWebToolStripMenuItem
            // 
            this.aplicacionWebToolStripMenuItem.Name = "aplicacionWebToolStripMenuItem";
            this.aplicacionWebToolStripMenuItem.Size = new System.Drawing.Size(127, 34);
            this.aplicacionWebToolStripMenuItem.Text = "Aplicacion Web";
            this.aplicacionWebToolStripMenuItem.Click += new System.EventHandler(this.aplicacionWebToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menui";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}