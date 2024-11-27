namespace WF_Practica2
{
    partial class AppCalculadora
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
            this.campoOperando1 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.campoOperando2 = new System.Windows.Forms.TextBox();
            this.campoResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoOperando1
            // 
            this.campoOperando1.BackColor = System.Drawing.SystemColors.Control;
            this.campoOperando1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoOperando1.Location = new System.Drawing.Point(28, 73);
            this.campoOperando1.Name = "campoOperando1";
            this.campoOperando1.Size = new System.Drawing.Size(346, 44);
            this.campoOperando1.TabIndex = 0;
            this.campoOperando1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(28, 261);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(82, 69);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28.2F, System.Drawing.FontStyle.Bold);
            this.btnResta.Location = new System.Drawing.Point(116, 261);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(82, 69);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28.2F, System.Drawing.FontStyle.Bold);
            this.btnProducto.Location = new System.Drawing.Point(204, 261);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(82, 69);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.Text = "×";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28.2F, System.Drawing.FontStyle.Bold);
            this.btnDivision.Location = new System.Drawing.Point(292, 261);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(82, 69);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese dos números";
            // 
            // campoOperando2
            // 
            this.campoOperando2.BackColor = System.Drawing.SystemColors.Control;
            this.campoOperando2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoOperando2.Location = new System.Drawing.Point(28, 136);
            this.campoOperando2.Name = "campoOperando2";
            this.campoOperando2.Size = new System.Drawing.Size(346, 44);
            this.campoOperando2.TabIndex = 8;
            this.campoOperando2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoResultado
            // 
            this.campoResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.campoResultado.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoResultado.Location = new System.Drawing.Point(28, 196);
            this.campoResultado.Name = "campoResultado";
            this.campoResultado.ReadOnly = true;
            this.campoResultado.Size = new System.Drawing.Size(346, 44);
            this.campoResultado.TabIndex = 9;
            this.campoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(204, 336);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 45);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AppCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 396);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.campoResultado);
            this.Controls.Add(this.campoOperando2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.campoOperando1);
            this.Name = "AppCalculadora";
            this.Text = "YAHIR ALEJANDRO SAAVEDRA GALLARDO, 21490577";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoOperando1;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoOperando2;
        private System.Windows.Forms.TextBox campoResultado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

