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
    public partial class ForClientes : Form
    {
        public ForClientes()
        {
            InitializeComponent();
            llenarTabla();
        }
        private void Consulta()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string consulta = "select RUTCliente, NombreCliente, ApellidoPaterno,ApellidoMaterno ,CorreoCliente, Telefono, DireccionCliente from Cliente where RUTCliente like ('" + textBox1.Text + "%')";
            //conexion.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Cerrar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void llenarTabla()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select RUTCliente, NombreCliente, ApellidoPaterno,ApellidoMaterno ,CorreoCliente, Telefono, DireccionCliente from Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
