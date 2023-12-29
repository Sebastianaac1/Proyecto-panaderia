using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrutosSecosAPP
{
    public partial class ForPedidos : Form
    {
        public ForPedidos()
        {
            InitializeComponent();
            llenarTabla();
        }
        private void llenarTabla()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select RUTCliente, NumerodeBoleta, PesoVenta, TotalVenta, HoraVenta, FechaVenta from Venta";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
