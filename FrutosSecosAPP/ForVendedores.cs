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
    public partial class ForVendedores : Form
    {
        public ForVendedores()
        {
            InitializeComponent();
            CargarDocumento();
        }

        private void ForVendedores_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }
        private void LlenarTabla()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select * from Vendedor";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedCells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedCells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedCells[7].Value.ToString();
            //dateTimePicker1.Text= dataGridView1.SelectedCells[8].ToString();
        }
        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            textBox7.Clear();
            textBox8.Clear();
            dataGridView1.ClearSelection();

        }
        private void Limpiartabla()
        {
            dataGridView1.DataSource = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public bool Existe()
        {
            bool rut = false;
            string cadena = ("Select RUTVendedor from Vendedor WHERE RUTVendedor = '" + textBox1.Text + "'");
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                rut = true;
            }
            conexion.Cerrar();
            return rut;
        }
        private void Grabar()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();

            if (Existe()==true)
            {
                MessageBox.Show("Rut ya es vendedor");
            }
            else
            {
                string query = "INSERT INTO Vendedor (RUTVendedor,NombreVendedor,ApellidopaVendedor,ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,TelefonoVendedor,FechadeCumpleaños) VALUES (@rut,@nombre,@apellidopa,@apellidoma,@direccion,@horario,@cargo,@telefono,@fecha)";
                SqlCommand cmd = new SqlCommand(query, conexion.conectarbd);
                cmd.Parameters.AddWithValue("@rut", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", this.textBox2.Text);
                cmd.Parameters.AddWithValue("@apellidopa", this.textBox3.Text);
                cmd.Parameters.AddWithValue("@apellidoma", this.textBox4.Text);
                cmd.Parameters.AddWithValue("@direccion", this.textBox5.Text);
                cmd.Parameters.AddWithValue("@horario", this.comboBox1.Text);
                cmd.Parameters.AddWithValue("@cargo", this.textBox7.Text);
                cmd.Parameters.AddWithValue("@telefono", this.textBox8.Text);
                cmd.Parameters.AddWithValue("@fecha", this.textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertado");
                conexion.Cerrar();
                CargarDocumento();
                Limpiartabla();
                LlenarTabla();
                Limpiar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Grabar();
        }
        private void CargarDocumento()
        {
            comboBox1.Items.Add("Lunes a Viernes de 08:00 AM a 18:00 PM");
            comboBox1.Items.Add("Sabado y Domingo de 08:00 AM a 18:00 PM");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string cadena = ("Delete From Vendedor where RUTVendedor ='" + textBox1.Text + "'");
            SqlCommand cmd = new SqlCommand(cadena, conexion.conectarbd);
            if (textBox1.Text.Length!=0)
            {
                int cant;
                cant = cmd.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Vendedor Eliminado");
                    Limpiartabla();
                    LlenarTabla();
                    Limpiar();
                } 
            }
            else
            {
                MessageBox.Show("Selecciones o escriba un rut");
            }
            conexion.Cerrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string cadena = ("UPDATE Vendedor SET NombreVendedor ='" + textBox2.Text + "', ApellidopaVendedor ='" + textBox3.Text + "', ApellidomaVendedor='" + textBox4.Text + "', DireccionVendedor='" + textBox5.Text + "', HorarioVendedor='" + comboBox1.Text  + "', CargoVendedor='" + textBox7.Text + "', TelefonoVendedor='" + textBox8.Text + "', FechadeCumpleaños='" + textBox6.Text + "'where RUTVendedor='" + textBox1.Text + "'");
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
