namespace FrutosSecosAPP
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRecuperar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FrutosSecosAPP.Properties.Resources.zyro_image__1__preview_rev_1;
            this.pictureBox3.Location = new System.Drawing.Point(27, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(317, 78);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(385, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(317, 165);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(385, 20);
            this.TxtContrasena.TabIndex = 2;
            this.TxtContrasena.Text = "CONTRASEÑA";
            this.TxtContrasena.Enter += new System.EventHandler(this.TxtContrasena_Enter);
            this.TxtContrasena.Leave += new System.EventHandler(this.TxtContrasena_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Location = new System.Drawing.Point(317, 249);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(167, 40);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "INGRESAR";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRecuperar
            // 
            this.BtnRecuperar.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnRecuperar.FlatAppearance.BorderSize = 0;
            this.BtnRecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnRecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.BtnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecuperar.Location = new System.Drawing.Point(535, 249);
            this.BtnRecuperar.Name = "BtnRecuperar";
            this.BtnRecuperar.Size = new System.Drawing.Size(167, 40);
            this.BtnRecuperar.TabIndex = 0;
            this.BtnRecuperar.Text = "RECUPERAR CONTRASEÑA";
            this.BtnRecuperar.UseVisualStyleBackColor = false;
            this.BtnRecuperar.Click += new System.EventHandler(this.BtnRecuperar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = global::FrutosSecosAPP.Properties.Resources.menos;
            this.BtnMinimizar.Location = new System.Drawing.Point(727, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnMinimizar.TabIndex = 10;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::FrutosSecosAPP.Properties.Resources.letra_x;
            this.BtnCerrar.Location = new System.Drawing.Point(758, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrutosSecosAPP.Properties.Resources.linea_negra;
            this.pictureBox1.Location = new System.Drawing.Point(317, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FrutosSecosAPP.Properties.Resources.linea_negra;
            this.pictureBox2.Location = new System.Drawing.Point(317, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(385, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnRecuperar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRecuperar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

