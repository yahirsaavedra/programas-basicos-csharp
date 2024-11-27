namespace WF_Practica3
{
    partial class AppComparar
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
            this.titulo = new System.Windows.Forms.Label();
            this.labelDato1 = new System.Windows.Forms.Label();
            this.labelDato2 = new System.Windows.Forms.Label();
            this.labelDato3 = new System.Windows.Forms.Label();
            this.campoDato1 = new System.Windows.Forms.TextBox();
            this.campoDato2 = new System.Windows.Forms.TextBox();
            this.campoDato3 = new System.Windows.Forms.TextBox();
            this.rbMayor = new System.Windows.Forms.RadioButton();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.campoResultado = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(120, 30);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(305, 40);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Comparar números";
            // 
            // labelDato1
            // 
            this.labelDato1.AutoSize = true;
            this.labelDato1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDato1.Location = new System.Drawing.Point(30, 92);
            this.labelDato1.Name = "labelDato1";
            this.labelDato1.Size = new System.Drawing.Size(110, 28);
            this.labelDato1.TabIndex = 1;
            this.labelDato1.Text = "Número 1";
            // 
            // labelDato2
            // 
            this.labelDato2.AutoSize = true;
            this.labelDato2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDato2.Location = new System.Drawing.Point(30, 135);
            this.labelDato2.Name = "labelDato2";
            this.labelDato2.Size = new System.Drawing.Size(114, 28);
            this.labelDato2.TabIndex = 2;
            this.labelDato2.Text = "Número 2";
            // 
            // labelDato3
            // 
            this.labelDato3.AutoSize = true;
            this.labelDato3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDato3.Location = new System.Drawing.Point(30, 178);
            this.labelDato3.Name = "labelDato3";
            this.labelDato3.Size = new System.Drawing.Size(114, 28);
            this.labelDato3.TabIndex = 3;
            this.labelDato3.Text = "Número 3";
            // 
            // campoDato1
            // 
            this.campoDato1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDato1.Location = new System.Drawing.Point(164, 92);
            this.campoDato1.Name = "campoDato1";
            this.campoDato1.Size = new System.Drawing.Size(188, 32);
            this.campoDato1.TabIndex = 4;
            // 
            // campoDato2
            // 
            this.campoDato2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDato2.Location = new System.Drawing.Point(164, 135);
            this.campoDato2.Name = "campoDato2";
            this.campoDato2.Size = new System.Drawing.Size(188, 32);
            this.campoDato2.TabIndex = 5;
            // 
            // campoDato3
            // 
            this.campoDato3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDato3.Location = new System.Drawing.Point(164, 178);
            this.campoDato3.Name = "campoDato3";
            this.campoDato3.Size = new System.Drawing.Size(188, 32);
            this.campoDato3.TabIndex = 6;
            // 
            // rbMayor
            // 
            this.rbMayor.AutoSize = true;
            this.rbMayor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMayor.Location = new System.Drawing.Point(382, 96);
            this.rbMayor.Name = "rbMayor";
            this.rbMayor.Size = new System.Drawing.Size(88, 28);
            this.rbMayor.TabIndex = 7;
            this.rbMayor.TabStop = true;
            this.rbMayor.Text = "Mayor";
            this.rbMayor.UseVisualStyleBackColor = true;
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenor.Location = new System.Drawing.Point(382, 139);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(89, 28);
            this.rbMenor.TabIndex = 8;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIntermedio.Location = new System.Drawing.Point(382, 182);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(130, 28);
            this.rbIntermedio.TabIndex = 9;
            this.rbIntermedio.TabStop = true;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // campoResultado
            // 
            this.campoResultado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoResultado.Location = new System.Drawing.Point(164, 245);
            this.campoResultado.Name = "campoResultado";
            this.campoResultado.Size = new System.Drawing.Size(188, 32);
            this.campoResultado.TabIndex = 10;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(374, 242);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(138, 37);
            this.btnComparar.TabIndex = 11;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // AppComparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.campoResultado);
            this.Controls.Add(this.rbIntermedio);
            this.Controls.Add(this.rbMenor);
            this.Controls.Add(this.rbMayor);
            this.Controls.Add(this.campoDato3);
            this.Controls.Add(this.campoDato2);
            this.Controls.Add(this.campoDato1);
            this.Controls.Add(this.labelDato3);
            this.Controls.Add(this.labelDato2);
            this.Controls.Add(this.labelDato1);
            this.Controls.Add(this.titulo);
            this.Name = "AppComparar";
            this.Text = "YAHIR ALEJANDRO SAAVEDRA GALLARDO, 21490577";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label labelDato1;
        private System.Windows.Forms.Label labelDato2;
        private System.Windows.Forms.Label labelDato3;
        private System.Windows.Forms.TextBox campoDato1;
        private System.Windows.Forms.TextBox campoDato2;
        private System.Windows.Forms.TextBox campoDato3;
        private System.Windows.Forms.RadioButton rbMayor;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.TextBox campoResultado;
        private System.Windows.Forms.Button btnComparar;
    }
}

