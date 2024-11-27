namespace ProyectoFinal_TAP
{
    partial class AppHistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppHistoria));
            this.tituloDescripcion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textoDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloDescripcion
            // 
            this.tituloDescripcion.AutoSize = true;
            this.tituloDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.tituloDescripcion.ForeColor = System.Drawing.Color.Black;
            this.tituloDescripcion.Location = new System.Drawing.Point(26, 29);
            this.tituloDescripcion.Name = "tituloDescripcion";
            this.tituloDescripcion.Size = new System.Drawing.Size(433, 55);
            this.tituloDescripcion.TabIndex = 2;
            this.tituloDescripcion.Text = "Historia de la empresa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal_TAP.Properties.Resources.cafeteria2;
            this.pictureBox2.Location = new System.Drawing.Point(585, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_TAP.Properties.Resources.cafeteria3;
            this.pictureBox1.Location = new System.Drawing.Point(36, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textoDescripcion
            // 
            this.textoDescripcion.AutoSize = true;
            this.textoDescripcion.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescripcion.ForeColor = System.Drawing.Color.Black;
            this.textoDescripcion.Location = new System.Drawing.Point(380, 102);
            this.textoDescripcion.Name = "textoDescripcion";
            this.textoDescripcion.Size = new System.Drawing.Size(658, 253);
            this.textoDescripcion.TabIndex = 5;
            this.textoDescripcion.Text = resources.GetString("textoDescripcion.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 230);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // AppHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1079, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoDescripcion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tituloDescripcion);
            this.Name = "AppHistoria";
            this.Text = "SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577";
            this.Load += new System.EventHandler(this.AppHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textoDescripcion;
        private System.Windows.Forms.Label label1;
    }
}