using FrutosSecosAPP.Clases;
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
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproductocli_Click(object sender, EventArgs e)
        {
            abrirProductos(new ProdCli());
        }

        private Form FormularioActivo = null;
        private void abrirProductos(Form PanMuestras)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = PanMuestras;
            PanMuestras.TopLevel = false;
            PanMuestras.FormBorderStyle = FormBorderStyle.None;
            PanMuestras.Dock = DockStyle.Fill;
            PanMuestraCLI.Controls.Add(PanMuestras);
            PanMuestraCLI.Tag = PanMuestras;
            PanMuestras.BringToFront();
            PanMuestras.Show();

        }



        private void btnsucurcli_Click(object sender, EventArgs e)
        {
            abrirProductos(new FormMap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Login lg = new Login();
           lg.Show();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNosotros_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForNosotros());
        }
    }
}
