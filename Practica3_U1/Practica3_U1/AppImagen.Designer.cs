namespace Practica3_U1
{
    partial class cambiarImagen
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
            this.textoPrograma = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.btnPerro = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // textoPrograma
            // 
            this.textoPrograma.AutoSize = true;
            this.textoPrograma.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrograma.Location = new System.Drawing.Point(23, 27);
            this.textoPrograma.Name = "textoPrograma";
            this.textoPrograma.Size = new System.Drawing.Size(463, 28);
            this.textoPrograma.TabIndex = 0;
            this.textoPrograma.Text = "Cambia la imagen haciendo clic en un botón";
            // 
            // imagen
            // 
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen.ImageLocation = "";
            this.imagen.Location = new System.Drawing.Point(249, 58);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(315, 279);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 1;
            this.imagen.TabStop = false;
            // 
            // btnPerro
            // 
            this.btnPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerro.Location = new System.Drawing.Point(177, 343);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(216, 49);
            this.btnPerro.TabIndex = 2;
            this.btnPerro.Text = "Imagen 1: Perro";
            this.btnPerro.UseVisualStyleBackColor = true;
            this.btnPerro.Click += new System.EventHandler(this.btnPerro_Click);
            // 
            // btnGato
            // 
            this.btnGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGato.Location = new System.Drawing.Point(412, 343);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(207, 49);
            this.btnGato.TabIndex = 3;
            this.btnGato.Text = "Imagen 2: Gato";
            this.btnGato.UseVisualStyleBackColor = true;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            // 
            // cambiarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnGato);
            this.Controls.Add(this.btnPerro);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.textoPrograma);
            this.Name = "cambiarImagen";
            this.Text = "SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoPrograma;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button btnPerro;
        private System.Windows.Forms.Button btnGato;
    }
}

