namespace LaAnalfabeta.Libro
{
    partial class PrestarLibro
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txIdentificacion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.rbtEstudiante = new System.Windows.Forms.RadioButton();
            this.rbtProfesor = new System.Windows.Forms.RadioButton();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.txInformacion = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Información del Libro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha Devolución:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo de User:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Identificación (ID):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código:";
            // 
            // txIdentificacion
            // 
            this.txIdentificacion.Location = new System.Drawing.Point(140, 90);
            this.txIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txIdentificacion.Name = "txIdentificacion";
            this.txIdentificacion.Size = new System.Drawing.Size(155, 22);
            this.txIdentificacion.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(265, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 38);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(15, 170);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(296, 22);
            this.dtpFechaDevolucion.TabIndex = 20;
            // 
            // rbtEstudiante
            // 
            this.rbtEstudiante.AutoSize = true;
            this.rbtEstudiante.Checked = true;
            this.rbtEstudiante.Location = new System.Drawing.Point(7, 58);
            this.rbtEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtEstudiante.Name = "rbtEstudiante";
            this.rbtEstudiante.Size = new System.Drawing.Size(91, 20);
            this.rbtEstudiante.TabIndex = 19;
            this.rbtEstudiante.TabStop = true;
            this.rbtEstudiante.Text = "Estudiante";
            this.rbtEstudiante.UseVisualStyleBackColor = true;
            // 
            // rbtProfesor
            // 
            this.rbtProfesor.AutoSize = true;
            this.rbtProfesor.Location = new System.Drawing.Point(7, 117);
            this.rbtProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtProfesor.Name = "rbtProfesor";
            this.rbtProfesor.Size = new System.Drawing.Size(79, 20);
            this.rbtProfesor.TabIndex = 18;
            this.rbtProfesor.Text = "Profesor";
            this.rbtProfesor.UseVisualStyleBackColor = true;
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(28, 308);
            this.btnPrestar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(183, 48);
            this.btnPrestar.TabIndex = 17;
            this.btnPrestar.Text = "Registrar Préstamo";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // picPortada
            // 
            this.picPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortada.Location = new System.Drawing.Point(28, 21);
            this.picPortada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(182, 254);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 16;
            this.picPortada.TabStop = false;
            // 
            // txInformacion
            // 
            this.txInformacion.Location = new System.Drawing.Point(23, 38);
            this.txInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txInformacion.Multiline = true;
            this.txInformacion.Name = "txInformacion";
            this.txInformacion.ReadOnly = true;
            this.txInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txInformacion.Size = new System.Drawing.Size(460, 142);
            this.txInformacion.TabIndex = 15;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(73, 33);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(155, 22);
            this.txCodigo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 15.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(560, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 35);
            this.label6.TabIndex = 28;
            this.label6.Text = "Prestar libro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txCodigo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaDevolucion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txIdentificacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(128, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 214);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txInformacion);
            this.panel2.Location = new System.Drawing.Point(16, 236);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 199);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rbtEstudiante);
            this.panel3.Controls.Add(this.rbtProfesor);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 217);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrestar);
            this.panel4.Controls.Add(this.picPortada);
            this.panel4.Location = new System.Drawing.Point(539, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 374);
            this.panel4.TabIndex = 32;
            // 
            // PrestarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrestarLibro";
            this.Text = "PrestarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIdentificacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.RadioButton rbtEstudiante;
        private System.Windows.Forms.RadioButton rbtProfesor;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.TextBox txInformacion;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}