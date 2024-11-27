using System.Windows.Forms;

namespace ProyectoFinal_TAP
{
    partial class AppMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appInternaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúDeAlimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appExternaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appInternaToolStripMenuItem,
            this.appExternaToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // appInternaToolStripMenuItem
            // 
            this.appInternaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúDeAlimentosToolStripMenuItem,
            this.historiaToolStripMenuItem});
            this.appInternaToolStripMenuItem.Name = "appInternaToolStripMenuItem";
            this.appInternaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.appInternaToolStripMenuItem.Text = "Sobre nosotros";
            // 
            // menúDeAlimentosToolStripMenuItem
            // 
            this.menúDeAlimentosToolStripMenuItem.Name = "menúDeAlimentosToolStripMenuItem";
            this.menúDeAlimentosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.menúDeAlimentosToolStripMenuItem.Text = "Menú de alimentos";
            this.menúDeAlimentosToolStripMenuItem.Click += new System.EventHandler(this.menúDeAlimentosToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // appExternaToolStripMenuItem
            // 
            this.appExternaToolStripMenuItem.Checked = true;
            this.appExternaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appExternaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.tablaToolStripMenuItem,
            this.presentaciónToolStripMenuItem,
            this.descripciónToolStripMenuItem});
            this.appExternaToolStripMenuItem.Name = "appExternaToolStripMenuItem";
            this.appExternaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.appExternaToolStripMenuItem.Text = "Compras";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.tablaToolStripMenuItem.Text = "Tabla";
            this.tablaToolStripMenuItem.Click += new System.EventHandler(this.tablaToolStripMenuItem_Click);
            // 
            // presentaciónToolStripMenuItem
            // 
            this.presentaciónToolStripMenuItem.Name = "presentaciónToolStripMenuItem";
            this.presentaciónToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.presentaciónToolStripMenuItem.Text = "Presentación";
            this.presentaciónToolStripMenuItem.Click += new System.EventHandler(this.presentaciónToolStripMenuItem_Click);
            // 
            // descripciónToolStripMenuItem
            // 
            this.descripciónToolStripMenuItem.Name = "descripciónToolStripMenuItem";
            this.descripciónToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.descripciónToolStripMenuItem.Text = "Descripción";
            this.descripciónToolStripMenuItem.Click += new System.EventHandler(this.descripciónToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(200, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 51);
            this.label3.TabIndex = 14;
            this.label3.Text = "C a f e t e r í a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(190, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 112);
            this.label2.TabIndex = 13;
            this.label2.Text = "Recreo Express";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(182, 203);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click_1);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Será como estar en casa...";
            // 
            // AppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(848, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppMenu";
            this.Text = "SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appInternaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appExternaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúDeAlimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private ToolStripMenuItem descripciónToolStripMenuItem;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem salidaToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private Label label1;
    }
}