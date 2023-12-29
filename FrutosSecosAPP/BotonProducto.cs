using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrutosSecosAPP
{
    public partial class BotonProducto : UserControl
    {
        private int id = 0;
        private int stock = 0;

        public BotonProducto()
        {
            InitializeComponent();
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Image ImageProducto
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string NameProducto
        {
            get { return label1.Text; }
            set { label1.Text = value; }
            
        }
        public string Precio
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
