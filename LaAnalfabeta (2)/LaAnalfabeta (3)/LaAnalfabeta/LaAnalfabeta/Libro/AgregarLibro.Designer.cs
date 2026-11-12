namespace LaAnalfabeta.Libro
{
    partial class AgregarLibro
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
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.chDisponible = new System.Windows.Forms.CheckBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.btSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btSeleccionar.Location = new System.Drawing.Point(336, 436);
            this.btSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(171, 36);
            this.btSeleccionar.TabIndex = 68;
            this.btSeleccionar.Text = "Seleccionar imagen";
            this.btSeleccionar.UseVisualStyleBackColor = false;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // picPortada
            // 
            this.picPortada.Location = new System.Drawing.Point(336, 152);
            this.picPortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(171, 235);
            this.picPortada.TabIndex = 67;
            this.picPortada.TabStop = false;
            this.picPortada.Paint += new System.Windows.Forms.PaintEventHandler(this.picPortada_Paint);
            // 
            // chDisponible
            // 
            this.chDisponible.AutoSize = true;
            this.chDisponible.Checked = true;
            this.chDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chDisponible.Location = new System.Drawing.Point(12, 179);
            this.chDisponible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chDisponible.Name = "chDisponible";
            this.chDisponible.Size = new System.Drawing.Size(75, 17);
            this.chDisponible.TabIndex = 66;
            this.chDisponible.Text = "Disponible";
            this.chDisponible.UseVisualStyleBackColor = true;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(183, 136);
            this.numStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(90, 20);
            this.numStock.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(181, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Stock";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // numAnio
            // 
            this.numAnio.Location = new System.Drawing.Point(183, 80);
            this.numAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(90, 20);
            this.numAnio.TabIndex = 63;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(488, 549);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 19);
            this.btCancelar.TabIndex = 62;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txISBN
            // 
            this.txISBN.Location = new System.Drawing.Point(273, 22);
            this.txISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txISBN.Multiline = true;
            this.txISBN.Name = "txISBN";
            this.txISBN.Size = new System.Drawing.Size(148, 28);
            this.txISBN.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(240, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "ISBN";
            // 
            // txCategoria
            // 
            this.txCategoria.Location = new System.Drawing.Point(183, 25);
            this.txCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCategoria.Multiline = true;
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.Size = new System.Drawing.Size(130, 30);
            this.txCategoria.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(181, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(181, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Año publicacion";
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.ForeColor = System.Drawing.Color.White;
            this.btConsultar.Location = new System.Drawing.Point(12, 275);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 29);
            this.btConsultar.TabIndex = 55;
            this.btConsultar.Text = "Guardar Libro";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txEditorial
            // 
            this.txEditorial.Location = new System.Drawing.Point(10, 136);
            this.txEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txEditorial.Multiline = true;
            this.txEditorial.Name = "txEditorial";
            this.txEditorial.Size = new System.Drawing.Size(135, 31);
            this.txEditorial.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Editorial";
            // 
            // txAutor
            // 
            this.txAutor.Location = new System.Drawing.Point(12, 80);
            this.txAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txAutor.Multiline = true;
            this.txAutor.Name = "txAutor";
            this.txAutor.Size = new System.Drawing.Size(133, 31);
            this.txAutor.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Autor";
            // 
            // txTitulo
            // 
            this.txTitulo.Location = new System.Drawing.Point(12, 25);
            this.txTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTitulo.Multiline = true;
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.Size = new System.Drawing.Size(133, 30);
            this.txTitulo.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Titulo";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(52, 22);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCodigo.Multiline = true;
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(148, 28);
            this.txCodigo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, -37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Actualizar Libro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(148, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 35);
            this.label9.TabIndex = 70;
            this.label9.Text = "Agregar Libro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txISBN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(9, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 63);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btConsultar);
            this.panel2.Controls.Add(this.txTitulo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txAutor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.chDisponible);
            this.panel2.Controls.Add(this.txEditorial);
            this.panel2.Controls.Add(this.numStock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numAnio);
            this.panel2.Controls.Add(this.txCategoria);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(9, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 319);
            this.panel2.TabIndex = 72;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(122, 275);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 29);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(546, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarLibro";
            this.Text = "AgregarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.CheckBox chDisponible;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
    }
}