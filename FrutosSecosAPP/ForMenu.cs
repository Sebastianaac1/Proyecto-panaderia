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
    public partial class ForMenu : Form
    {
        public ForMenu()
        {
            InitializeComponent();
        }

        private void Abirformhija(object formhija)
        {
            //el padre de todas las busquedas

            if (this.PanMuestra.Controls.Count > 0)
                this.PanMuestra.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanMuestra.Controls.Add(fh);
            this.PanMuestra.Tag = fh;
            fh.Show();
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            Abirformhija(new ForPunto());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForProductos());
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
            PanMuestra.Controls.Add(PanMuestras);
            PanMuestra.Tag = PanMuestras;
            PanMuestras.BringToFront();
            PanMuestras.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirProductos(new FormMap());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForClientes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForPedidos());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //no tocar ni borrar
        private void PanMuestra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReAD_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForRegistroAdmin());
        }

        private void BtnRECLI_Click(object sender, EventArgs e)
        {
            abrirProductos(new ForRegistroCliente());
        }
    }
}
