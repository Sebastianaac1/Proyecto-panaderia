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
    public partial class ForRegistroAdmin : Form
    {
        public ForRegistroAdmin()
        {
            InitializeComponent();
        }
        public bool Existe()
        {
            bool rut = false;
            string cadena = ("Select RUTVendedor from Vendedor WHERE RUTVendedor = '" + txtUsuario.Text + "'");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Existe() == true)
            {
                Registro();
            }
            else
            {
                MessageBox.Show("Persona no es un empleado");
            }
        }
        private void Registro()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();

            string query = "INSERT INTO Usuarios (NombreUsuario,ClaveUsuario,TipoUsuario) VALUES (@rut,@clave,@tipo)";
            SqlCommand cmd = new SqlCommand(query, conexion.conectarbd);
            cmd.Parameters.AddWithValue("@rut", this.txtUsuario.Text);
            cmd.Parameters.AddWithValue("@clave", this.txtContraseña.Text);
            cmd.Parameters.AddWithValue("@tipo", this.lblAdmin.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conexion.Cerrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }
    }
}
