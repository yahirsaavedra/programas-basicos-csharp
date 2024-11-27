namespace HilosGUI
{
    partial class Carrera
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
            this.INICIAR = new System.Windows.Forms.Button();
            this.lombor = new System.Windows.Forms.PictureBox();
            this.mustan = new System.Windows.Forms.PictureBox();
            this.camaro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lombor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mustan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaro)).BeginInit();
            this.SuspendLayout();
            // 
            // INICIAR
            // 
            this.INICIAR.Location = new System.Drawing.Point(660, 383);
            this.INICIAR.Name = "INICIAR";
            this.INICIAR.Size = new System.Drawing.Size(115, 46);
            this.INICIAR.TabIndex = 3;
            this.INICIAR.Text = "INICIAR";
            this.INICIAR.UseVisualStyleBackColor = true;
            this.INICIAR.Click += new System.EventHandler(this.INICIAR_Click);
            // 
            // lombor
            // 
            this.lombor.Image = global::HilosGUI.Properties.Resources.carro3;
            this.lombor.Location = new System.Drawing.Point(42, 262);
            this.lombor.Name = "lombor";
            this.lombor.Size = new System.Drawing.Size(152, 98);
            this.lombor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lombor.TabIndex = 1;
            this.lombor.TabStop = false;
            this.lombor.Click += new System.EventHandler(this.camaro_Click);
            // 
            // mustan
            // 
            this.mustan.Image = global::HilosGUI.Properties.Resources.carro2;
            this.mustan.Location = new System.Drawing.Point(42, 158);
            this.mustan.Name = "mustan";
            this.mustan.Size = new System.Drawing.Size(170, 84);
            this.mustan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mustan.TabIndex = 2;
            this.mustan.TabStop = false;
            // 
            // camaro
            // 
            this.camaro.Image = global::HilosGUI.Properties.Resources.carro1;
            this.camaro.Location = new System.Drawing.Point(42, 12);
            this.camaro.Name = "camaro";
            this.camaro.Size = new System.Drawing.Size(125, 106);
            this.camaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camaro.TabIndex = 0;
            this.camaro.TabStop = false;
            this.camaro.Click += new System.EventHandler(this.camaro_Click_1);
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INICIAR);
            this.Controls.Add(this.mustan);
            this.Controls.Add(this.lombor);
            this.Controls.Add(this.camaro);
            this.Name = "Carrera";
            this.Text = "SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.lombor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mustan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camaro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button INICIAR;
        private System.Windows.Forms.PictureBox lombor;
        private System.Windows.Forms.PictureBox mustan;
        private System.Windows.Forms.PictureBox camaro;
    }
}