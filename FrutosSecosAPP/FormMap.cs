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
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = FrutosSecosAPP.Properties.Resources.Captura_de_pantalla_2022_06_23_202402;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = FrutosSecosAPP.Properties.Resources.Captura_de_pantalla_2_2022_06_23_204516;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = FrutosSecosAPP.Properties.Resources.Captura_de_pantalla_3_2022_06_23_204802;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = FrutosSecosAPP.Properties.Resources.Captura_de_pantalla_4_2022_06_23_204851;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = FrutosSecosAPP.Properties.Resources.Captura_de_pantalla_5_2022_06_23_204947;
        }
    }
}
