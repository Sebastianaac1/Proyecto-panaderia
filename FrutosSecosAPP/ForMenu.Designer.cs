using System;

namespace FrutosSecosAPP
{
    partial class ForMenu
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
            this.PanMenu = new System.Windows.Forms.Panel();
            this.BtnRECLI = new System.Windows.Forms.Button();
            this.BtnReAD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanMuestra = new System.Windows.Forms.Panel();
            this.PanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanMenu
            // 
            this.PanMenu.BackColor = System.Drawing.Color.Peru;
            this.PanMenu.Controls.Add(this.BtnRECLI);
            this.PanMenu.Controls.Add(this.BtnReAD);
            this.PanMenu.Controls.Add(this.button5);
            this.PanMenu.Controls.Add(this.button4);
            this.PanMenu.Controls.Add(this.button3);
            this.PanMenu.Controls.Add(this.button2);
            this.PanMenu.Controls.Add(this.BtnPunto);
            this.PanMenu.Controls.Add(this.label2);
            this.PanMenu.Controls.Add(this.label1);
            this.PanMenu.Controls.Add(this.pictureBox3);
            this.PanMenu.Controls.Add(this.BtnCerrar);
            this.PanMenu.Controls.Add(this.BtnMinimizar);
            this.PanMenu.Controls.Add(this.pictureBox1);
            this.PanMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanMenu.Location = new System.Drawing.Point(0, 0);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(1154, 120);
            this.PanMenu.TabIndex = 0;
            this.PanMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanMenu_Paint);
            // 
            // BtnRECLI
            // 
            this.BtnRECLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRECLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRECLI.Image = global::FrutosSecosAPP.Properties.Resources.compras;
            this.BtnRECLI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRECLI.Location = new System.Drawing.Point(675, 85);
            this.BtnRECLI.Name = "BtnRECLI";
            this.BtnRECLI.Size = new System.Drawing.Size(140, 35);
            this.BtnRECLI.TabIndex = 23;
            this.BtnRECLI.Text = "Registro Cliente";
            this.BtnRECLI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRECLI.UseVisualStyleBackColor = true;
            this.BtnRECLI.Click += new System.EventHandler(this.BtnRECLI_Click);
            // 
            // BtnReAD
            // 
            this.BtnReAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReAD.Image = global::FrutosSecosAPP.Properties.Resources.jefe;
            this.BtnReAD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReAD.Location = new System.Drawing.Point(539, 85);
            this.BtnReAD.Name = "BtnReAD";
            this.BtnReAD.Size = new System.Drawing.Size(136, 35);
            this.BtnReAD.TabIndex = 22;
            this.BtnReAD.Text = "Registro Admin";
            this.BtnReAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReAD.UseVisualStyleBackColor = true;
            this.BtnReAD.Click += new System.EventHandler(this.BtnReAD_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::FrutosSecosAPP.Properties.Resources.bolsa_de_la_compra;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(445, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "Pedidos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::FrutosSecosAPP.Properties.Resources.objetivo;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(352, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Clientes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::FrutosSecosAPP.Properties.Resources.tienda__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(240, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sucursales";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::FrutosSecosAPP.Properties.Resources.caja;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(137, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Productos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnPunto
            // 
            this.BtnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.Image = global::FrutosSecosAPP.Properties.Resources.carros__2_;
            this.BtnPunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPunto.Location = new System.Drawing.Point(0, 85);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(137, 35);
            this.BtnPunto.TabIndex = 17;
            this.BtnPunto.Text = "Punto de Venta";
            this.BtnPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1023, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CARGO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1023, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FrutosSecosAPP.Properties.Resources.zyro_image__1__preview_rev_1;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::FrutosSecosAPP.Properties.Resources.letra_x;
            this.BtnCerrar.Location = new System.Drawing.Point(1131, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = global::FrutosSecosAPP.Properties.Resources.menos;
            this.BtnMinimizar.Location = new System.Drawing.Point(1105, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnMinimizar.TabIndex = 11;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrutosSecosAPP.Properties.Resources.icons8_trabajador_de_sexo_masculino_64;
            this.pictureBox1.Location = new System.Drawing.Point(956, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanMuestra
            // 
            this.PanMuestra.Location = new System.Drawing.Point(0, 120);
            this.PanMuestra.Name = "PanMuestra";
            this.PanMuestra.Size = new System.Drawing.Size(1154, 561);
            this.PanMuestra.TabIndex = 1;
            this.PanMuestra.Paint += new System.Windows.Forms.PaintEventHandler(this.PanMuestra_Paint);
            // 
            // ForMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 680);
            this.Controls.Add(this.PanMuestra);
            this.Controls.Add(this.PanMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForMenu";
            this.Text = "ForMenu";
            this.PanMenu.ResumeLayout(false);
            this.PanMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //hola
        }

        #endregion

        private System.Windows.Forms.Panel PanMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanMuestra;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRECLI;
        private System.Windows.Forms.Button BtnReAD;
    }
}