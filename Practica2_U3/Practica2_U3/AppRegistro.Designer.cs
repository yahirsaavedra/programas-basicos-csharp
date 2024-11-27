namespace Practica2_U3
{
    partial class AppRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.GroupBox();
            this.mujer = new System.Windows.Forms.RadioButton();
            this.hombre = new System.Windows.Forms.RadioButton();
            this.txtvalida = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtam = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.escuela = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnTabla = new System.Windows.Forms.Button();
            this.registros = new System.Windows.Forms.GroupBox();
            this.btnCambio = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.SALIDA = new System.Windows.Forms.ListBox();
            this.cbImagen = new System.Windows.Forms.ComboBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.genero.SuspendLayout();
            this.registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ap. Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ap. Materno";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Gold;
            this.titulo.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(397, 29);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(137, 42);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Institución académica";
            // 
            // genero
            // 
            this.genero.Controls.Add(this.mujer);
            this.genero.Controls.Add(this.hombre);
            this.genero.Location = new System.Drawing.Point(533, 94);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(120, 100);
            this.genero.TabIndex = 8;
            this.genero.TabStop = false;
            this.genero.Text = "Género";
            // 
            // mujer
            // 
            this.mujer.AutoSize = true;
            this.mujer.Location = new System.Drawing.Point(23, 60);
            this.mujer.Name = "mujer";
            this.mujer.Size = new System.Drawing.Size(61, 20);
            this.mujer.TabIndex = 1;
            this.mujer.TabStop = true;
            this.mujer.Text = "Mujer";
            this.mujer.UseVisualStyleBackColor = true;
            // 
            // hombre
            // 
            this.hombre.AutoSize = true;
            this.hombre.Location = new System.Drawing.Point(23, 34);
            this.hombre.Name = "hombre";
            this.hombre.Size = new System.Drawing.Size(77, 20);
            this.hombre.TabIndex = 0;
            this.hombre.TabStop = true;
            this.hombre.Text = "Hombre";
            this.hombre.UseVisualStyleBackColor = true;
            // 
            // txtvalida
            // 
            this.txtvalida.Location = new System.Drawing.Point(116, 101);
            this.txtvalida.Name = "txtvalida";
            this.txtvalida.Size = new System.Drawing.Size(376, 22);
            this.txtvalida.TabIndex = 9;
            this.txtvalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalida_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(116, 133);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(376, 22);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_TextChanged);
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(116, 164);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(376, 22);
            this.txtap.TabIndex = 11;
            this.txtap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtap_TextChanged);
            // 
            // txtam
            // 
            this.txtam.Location = new System.Drawing.Point(116, 197);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(376, 22);
            this.txtam.TabIndex = 12;
            this.txtam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtam_TextChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(533, 238);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(376, 22);
            this.mail.TabIndex = 13;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            this.mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mail_TextChanged);
            // 
            // escuela
            // 
            this.escuela.Location = new System.Drawing.Point(533, 294);
            this.escuela.Name = "escuela";
            this.escuela.Size = new System.Drawing.Size(376, 22);
            this.escuela.TabIndex = 14;
            this.escuela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.escuela_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(556, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 27);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(679, 333);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 27);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(797, 333);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(97, 27);
            this.btnTabla.TabIndex = 17;
            this.btnTabla.Text = "Tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // registros
            // 
            this.registros.Controls.Add(this.btnCambio);
            this.registros.Controls.Add(this.btnBaja);
            this.registros.Controls.Add(this.btnAlta);
            this.registros.Enabled = false;
            this.registros.Location = new System.Drawing.Point(533, 379);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(376, 95);
            this.registros.TabIndex = 9;
            this.registros.TabStop = false;
            this.registros.Text = "Registro";
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(251, 39);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(97, 27);
            this.btnCambio.TabIndex = 20;
            this.btnCambio.Text = "Cambio";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(136, 39);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(97, 27);
            this.btnBaja.TabIndex = 19;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(23, 39);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(97, 27);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // SALIDA
            // 
            this.SALIDA.FormattingEnabled = true;
            this.SALIDA.ItemHeight = 16;
            this.SALIDA.Location = new System.Drawing.Point(34, 238);
            this.SALIDA.Name = "SALIDA";
            this.SALIDA.Size = new System.Drawing.Size(268, 228);
            this.SALIDA.TabIndex = 18;
            // 
            // cbImagen
            // 
            this.cbImagen.FormattingEnabled = true;
            this.cbImagen.Items.AddRange(new object[] {
            "Imagen no. 1",
            "Imagen no. 2",
            "Imagen no. 3"});
            this.cbImagen.Location = new System.Drawing.Point(308, 442);
            this.cbImagen.Name = "cbImagen";
            this.cbImagen.Size = new System.Drawing.Size(219, 24);
            this.cbImagen.TabIndex = 19;
            this.cbImagen.SelectedIndexChanged += new System.EventHandler(this.cbImagen_SelectedIndexChanged);
            // 
            // imagen
            // 
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagen.Location = new System.Drawing.Point(309, 238);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(215, 198);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 20;
            this.imagen.TabStop = false;
            // 
            // AppRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(928, 491);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.cbImagen);
            this.Controls.Add(this.SALIDA);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.escuela);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.txtam);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtvalida);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppRegistro";
            this.Text = "SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577";
            this.genero.ResumeLayout(false);
            this.genero.PerformLayout();
            this.registros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox genero;
        private System.Windows.Forms.RadioButton mujer;
        private System.Windows.Forms.RadioButton hombre;
        private System.Windows.Forms.TextBox txtvalida;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox escuela;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.GroupBox registros;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox SALIDA;
        private System.Windows.Forms.ComboBox cbImagen;
        private System.Windows.Forms.PictureBox imagen;
    }
}

