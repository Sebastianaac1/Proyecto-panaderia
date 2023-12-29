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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }
        private void LlenarTabla()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select * from Proveedor";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }
        private void FormProveedor_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dataGridView1.ClearSelection();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiartabla()
        {
            dataGridView1.DataSource = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();

            string query = "INSERT INTO Proveedor (RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor) VALUES (@rut,@nombre,@apellidopa,@apellidoma,@direccion,@telefono)";
            SqlCommand cmd = new SqlCommand(query, conexion.conectarbd);
            cmd.Parameters.AddWithValue("@rut", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@nombre", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@apellidopa", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@apellidoma", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@direccion", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@telefono", this.textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conexion.Cerrar();
            Limpiartabla();
            LlenarTabla();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string cadena = ("Delete From Proveedor where RUTProveedor ='" + textBox1.Text + "'");
            SqlCommand cmd = new SqlCommand(cadena, conexion.conectarbd);
            int cant;
            cant = cmd.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Proveedor Eliminado");
                Limpiartabla();
                LlenarTabla();
                Limpiar();
            }
            conexion.Cerrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string cadena = ("UPDATE Proveedor SET NombreProveedor ='" + textBox2.Text + "', ApellidoPaProveedor ='" + textBox3.Text + "', ApellidoMaProveedor='" + textBox4.Text + "', DireccionProveedor='" +textBox5.Text + "', TelefonoProveedor='" + textBox6.Text + "'where RUTProveedor='" + textBox1.Text + "'");
            SqlCommand cmd = new SqlCommand(cadena, conexion.conectarbd);
            int cant;
            cant = cmd.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Actualizado");
                Limpiartabla();
                LlenarTabla();
                Limpiar();
            }
            conexion.Cerrar();
        }
        
    }
    
}
