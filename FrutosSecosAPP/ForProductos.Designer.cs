namespace FrutosSecosAPP
{
    partial class ForProductos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ensayoBasededatosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ensayoBasededatosDataSet = new FrutosSecosAPP.EnsayoBasededatosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CProducto = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.GuardarVentas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new FrutosSecosAPP.EnsayoBasededatosDataSetTableAdapters.ProductoTableAdapter();
            this.BorrarDato = new System.Windows.Forms.Button();
            this.BorrarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensayoBasededatosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensayoBasededatosDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.iDCategoriaDataGridViewTextBoxColumn,
            this.stockProductoDataGridViewTextBoxColumn,
            this.valorProductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(275, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(612, 135);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDCategoriaDataGridViewTextBoxColumn
            // 
            this.iDCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IDCategoria";
            this.iDCategoriaDataGridViewTextBoxColumn.HeaderText = "IDCategoria";
            this.iDCategoriaDataGridViewTextBoxColumn.Name = "iDCategoriaDataGridViewTextBoxColumn";
            this.iDCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockProductoDataGridViewTextBoxColumn
            // 
            this.stockProductoDataGridViewTextBoxColumn.DataPropertyName = "StockProducto";
            this.stockProductoDataGridViewTextBoxColumn.HeaderText = "StockProducto";
            this.stockProductoDataGridViewTextBoxColumn.Name = "stockProductoDataGridViewTextBoxColumn";
            this.stockProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorProductoDataGridViewTextBoxColumn
            // 
            this.valorProductoDataGridViewTextBoxColumn.DataPropertyName = "ValorProducto";
            this.valorProductoDataGridViewTextBoxColumn.HeaderText = "ValorProducto";
            this.valorProductoDataGridViewTextBoxColumn.Name = "valorProductoDataGridViewTextBoxColumn";
            this.valorProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.ensayoBasededatosDataSetBindingSource;
            // 
            // ensayoBasededatosDataSetBindingSource
            // 
            this.ensayoBasededatosDataSetBindingSource.DataSource = this.ensayoBasededatosDataSet;
            this.ensayoBasededatosDataSetBindingSource.Position = 0;
            // 
            // ensayoBasededatosDataSet
            // 
            this.ensayoBasededatosDataSet.DataSetName = "EnsayoBasededatosDataSet";
            this.ensayoBasededatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CProducto);
            this.groupBox1.Controls.Add(this.Stock);
            this.groupBox1.Controls.Add(this.GuardarVentas);
            this.groupBox1.Controls.Add(this.BorrarVentas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Precio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NombreP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "(No Utilizar Esto)";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(165, 85);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 13;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(918, 94);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(153, 69);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock";
            // 
            // CProducto
            // 
            this.CProducto.Location = new System.Drawing.Point(165, 37);
            this.CProducto.Name = "CProducto";
            this.CProducto.Size = new System.Drawing.Size(121, 20);
            this.CProducto.TabIndex = 0;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(673, 34);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(121, 20);
            this.Stock.TabIndex = 10;
            // 
            // GuardarVentas
            // 
            this.GuardarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarVentas.Location = new System.Drawing.Point(918, 19);
            this.GuardarVentas.Name = "GuardarVentas";
            this.GuardarVentas.Size = new System.Drawing.Size(153, 69);
            this.GuardarVentas.TabIndex = 9;
            this.GuardarVentas.Text = "Guardar";
            this.GuardarVentas.UseVisualStyleBackColor = true;
            this.GuardarVentas.Click += new System.EventHandler(this.GuardarVentas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Producto $";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(453, 83);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(121, 20);
            this.Precio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Producto";
            // 
            // NombreP
            // 
            this.NombreP.Location = new System.Drawing.Point(453, 34);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(121, 20);
            this.NombreP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(521, 422);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 69);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "Consultar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.ensayoBasededatosDataSetBindingSource;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // BorrarDato
            // 
            this.BorrarDato.Location = new System.Drawing.Point(930, 324);
            this.BorrarDato.Name = "BorrarDato";
            this.BorrarDato.Size = new System.Drawing.Size(74, 23);
            this.BorrarDato.TabIndex = 14;
            this.BorrarDato.Text = "Borrar dato";
            this.BorrarDato.UseVisualStyleBackColor = true;
            this.BorrarDato.Click += new System.EventHandler(this.BorrarDato_Click);
            // 
            // BorrarVentas
            // 
            this.BorrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarVentas.Image = global::FrutosSecosAPP.Properties.Resources.eliminar__1_;
            this.BorrarVentas.Location = new System.Drawing.Point(626, 75);
            this.BorrarVentas.Name = "BorrarVentas";
            this.BorrarVentas.Size = new System.Drawing.Size(36, 35);
            this.BorrarVentas.TabIndex = 8;
            this.BorrarVentas.UseVisualStyleBackColor = true;
            this.BorrarVentas.Click += new System.EventHandler(this.BorrarVentas_Click);
            // 
            // ForProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 522);
            this.Controls.Add(this.BorrarDato);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForProductos";
            this.Text = "ForProductos";
            this.Load += new System.EventHandler(this.ForProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensayoBasededatosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensayoBasededatosDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Button GuardarVentas;
        private System.Windows.Forms.Button BorrarVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CProducto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private EnsayoBasededatosDataSet ensayoBasededatosDataSet;
        private System.Windows.Forms.BindingSource ensayoBasededatosDataSetBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private EnsayoBasededatosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.Button BorrarDato;
    }
}