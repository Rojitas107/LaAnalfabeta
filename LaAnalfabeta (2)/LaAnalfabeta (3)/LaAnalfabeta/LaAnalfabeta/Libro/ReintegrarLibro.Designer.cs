namespace LaAnalfabeta.Libro
{
    partial class ReintegrarLibro
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.txObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.txIdProfesor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txIdEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txIdLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txIdPrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(327, 11);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 33);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnEntregar.ForeColor = System.Drawing.Color.White;
            this.btnEntregar.Location = new System.Drawing.Point(473, 291);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(116, 48);
            this.btnEntregar.TabIndex = 40;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // txObservaciones
            // 
            this.txObservaciones.Location = new System.Drawing.Point(169, 16);
            this.txObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txObservaciones.Multiline = true;
            this.txObservaciones.Name = "txObservaciones";
            this.txObservaciones.Size = new System.Drawing.Size(187, 66);
            this.txObservaciones.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Observaciones";
            // 
            // picPortada
            // 
            this.picPortada.Location = new System.Drawing.Point(455, 74);
            this.picPortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(143, 189);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 37;
            this.picPortada.TabStop = false;
            // 
            // txIdProfesor
            // 
            this.txIdProfesor.Location = new System.Drawing.Point(150, 171);
            this.txIdProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIdProfesor.Name = "txIdProfesor";
            this.txIdProfesor.ReadOnly = true;
            this.txIdProfesor.Size = new System.Drawing.Size(130, 20);
            this.txIdProfesor.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID del Profesor";
            // 
            // txIdEstudiante
            // 
            this.txIdEstudiante.Location = new System.Drawing.Point(150, 118);
            this.txIdEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIdEstudiante.Name = "txIdEstudiante";
            this.txIdEstudiante.ReadOnly = true;
            this.txIdEstudiante.Size = new System.Drawing.Size(130, 20);
            this.txIdEstudiante.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID del Estudiante";
            // 
            // txIdLibro
            // 
            this.txIdLibro.Location = new System.Drawing.Point(150, 63);
            this.txIdLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIdLibro.Name = "txIdLibro";
            this.txIdLibro.ReadOnly = true;
            this.txIdLibro.Size = new System.Drawing.Size(130, 20);
            this.txIdLibro.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID del Libro";
            // 
            // txIdPrestamo
            // 
            this.txIdPrestamo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txIdPrestamo.Location = new System.Drawing.Point(150, 16);
            this.txIdPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIdPrestamo.Name = "txIdPrestamo";
            this.txIdPrestamo.Size = new System.Drawing.Size(130, 20);
            this.txIdPrestamo.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID del prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reintegrar Libro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txIdPrestamo);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.txIdLibro);
            this.panel1.Controls.Add(this.txIdEstudiante);
            this.panel1.Controls.Add(this.txIdProfesor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 207);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txObservaciones);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 100);
            this.panel2.TabIndex = 43;
            // 
            // ReintegrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReintegrarLibro";
            this.Text = "ReintegrarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.TextBox txObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.TextBox txIdProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txIdEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txIdLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txIdPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}