namespace LaAnalfabeta.Libro
{
    partial class ActualizarLibro
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
            this.btActualizar = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.chDisponible = new System.Windows.Forms.CheckBox();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPortada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.ForeColor = System.Drawing.Color.White;
            this.btActualizar.Location = new System.Drawing.Point(18, 358);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(113, 42);
            this.btActualizar.TabIndex = 29;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.ForeColor = System.Drawing.Color.White;
            this.btConsultar.Location = new System.Drawing.Point(576, 22);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(123, 38);
            this.btConsultar.TabIndex = 28;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click_1);
            // 
            // txEditorial
            // 
            this.txEditorial.Location = new System.Drawing.Point(18, 196);
            this.txEditorial.Multiline = true;
            this.txEditorial.Name = "txEditorial";
            this.txEditorial.ReadOnly = true;
            this.txEditorial.Size = new System.Drawing.Size(165, 40);
            this.txEditorial.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(15, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Editorial";
            // 
            // txAutor
            // 
            this.txAutor.Location = new System.Drawing.Point(18, 124);
            this.txAutor.Multiline = true;
            this.txAutor.Name = "txAutor";
            this.txAutor.ReadOnly = true;
            this.txAutor.Size = new System.Drawing.Size(165, 39);
            this.txAutor.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Autor";
            // 
            // txTitulo
            // 
            this.txTitulo.Location = new System.Drawing.Point(18, 40);
            this.txTitulo.Multiline = true;
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.ReadOnly = true;
            this.txTitulo.Size = new System.Drawing.Size(165, 39);
            this.txTitulo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Titulo";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(72, 22);
            this.txCodigo.Multiline = true;
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(164, 38);
            this.txCodigo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(236, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Actualizar Libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.picPortada_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(272, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Año publicacion";
            // 
            // txCategoria
            // 
            this.txCategoria.Location = new System.Drawing.Point(271, 40);
            this.txCategoria.Multiline = true;
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.ReadOnly = true;
            this.txCategoria.Size = new System.Drawing.Size(193, 39);
            this.txCategoria.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(268, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Categoria";
            // 
            // txISBN
            // 
            this.txISBN.Location = new System.Drawing.Point(327, 22);
            this.txISBN.Multiline = true;
            this.txISBN.Name = "txISBN";
            this.txISBN.ReadOnly = true;
            this.txISBN.Size = new System.Drawing.Size(163, 38);
            this.txISBN.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(283, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "ISBN";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(153, 358);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(113, 42);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // numAnio
            // 
            this.numAnio.Location = new System.Drawing.Point(271, 120);
            this.numAnio.Name = "numAnio";
            this.numAnio.ReadOnly = true;
            this.numAnio.Size = new System.Drawing.Size(120, 22);
            this.numAnio.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(268, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Stock";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(271, 197);
            this.numStock.Name = "numStock";
            this.numStock.ReadOnly = true;
            this.numStock.Size = new System.Drawing.Size(120, 22);
            this.numStock.TabIndex = 41;
            // 
            // chDisponible
            // 
            this.chDisponible.AutoSize = true;
            this.chDisponible.Checked = true;
            this.chDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chDisponible.Location = new System.Drawing.Point(18, 262);
            this.chDisponible.Name = "chDisponible";
            this.chDisponible.Size = new System.Drawing.Size(94, 20);
            this.chDisponible.TabIndex = 42;
            this.chDisponible.Text = "Disponible";
            this.chDisponible.UseVisualStyleBackColor = true;
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btSeleccionar.Location = new System.Drawing.Point(508, 513);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(253, 46);
            this.btSeleccionar.TabIndex = 44;
            this.btSeleccionar.Text = "Seleccionar imagen";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            this.btSeleccionar.Paint += new System.Windows.Forms.PaintEventHandler(this.picPortada_Paint_1);
            // 
            // btQuitar
            // 
            this.btQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btQuitar.Location = new System.Drawing.Point(508, 565);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(253, 46);
            this.btQuitar.TabIndex = 45;
            this.btQuitar.Text = "Quitar imagen";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click_1);
            this.btQuitar.Paint += new System.Windows.Forms.PaintEventHandler(this.picPortada_Paint_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txISBN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btConsultar);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 82);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txTitulo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txAutor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.numStock);
            this.panel2.Controls.Add(this.btActualizar);
            this.panel2.Controls.Add(this.chDisponible);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txEditorial);
            this.panel2.Controls.Add(this.numAnio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txCategoria);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 413);
            this.panel2.TabIndex = 47;
            // 
            // picPortada
            // 
            this.picPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortada.Location = new System.Drawing.Point(508, 198);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(253, 297);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 43;
            this.picPortada.TabStop = false;
            this.picPortada.Click += new System.EventHandler(this.picPortada_Click);
            this.picPortada.Paint += new System.Windows.Forms.PaintEventHandler(this.picPortada_Paint_1);
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(784, 634);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActualizarLibro";
            this.Text = "ActualizarLibro";
            this.Load += new System.EventHandler(this.ActualizarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualizar;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.CheckBox chDisponible;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPortada;
    }
}