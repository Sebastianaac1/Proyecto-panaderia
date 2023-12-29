using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FrutosSecosAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "CONTRASEÑA")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "CONTRASEÑA";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }
        private bool ConectarAdmins()
        {
            bool f = false;
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string Rut;
            Rut = TxtUsuario.Text;
            string contraseña;

            contraseña = TxtContrasena.Text;
            string cadena = "SELECT * FROM Usuarios WHERE NombreUsuario='" + Rut + "'and ClaveUsuario='" + contraseña + "'and TipoUsuario='" + "ADMIN" + "'";
            
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                SqlDataReader lector = comando.ExecuteReader();
                
                if (lector.HasRows == true)
                {
                    f = true;
                }
                
                else
                {
                    
                    f = false;
                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta" + ex.Message);
            }
            return f;
        }
        private bool ConectarClientes()
        {
            bool f = false;
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string Rut;
            Rut = TxtUsuario.Text;
            string contraseña;

            contraseña = TxtContrasena.Text;
            string cadena = "SELECT * FROM Usuarios WHERE NombreUsuario='" + Rut + "'and ClaveUsuario='" + contraseña + "'and TipoUsuario='"+"CLIENTE"+"'";
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows == true)
                {

                    f = true;
                }
                else
                {
                    
                    f= false;
                }
                
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta" + ex.Message);
            }

            return f;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            if (ConectarAdmins() == true)
            {
                
                MessageBox.Show("Bienvenido Administrador");
                this.Hide();
                ForMenu FM = new ForMenu();
                
                
                
                FM.label1.Text = TxtUsuario.Text;
                FM.Show();
                FM.label2.Text = "ADMINISTADOR";
            }
            
            else if(ConectarClientes() == true)
            {

                MessageBox.Show("Bienvenido Cliente");
                this.Hide();
                MenuClientes MC  = new MenuClientes();
                MC.Show();


                MC.NomCLI.Text = TxtUsuario.Text;
                MC.Show();
                MC.NomCLI.Visible = true;
                MC.bienvenida.Visible = true;
                MC.button1.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }




            
        }

        private bool Validar()
        {
            bool estaOk = false;
            string patronRut = @"\A[1-9][0-9]?.[0-9]{3}.[0-9]{3}-[0-9k]\Z";
            string patronContra = @"\dddd\Z";
            if (!Regex.IsMatch(TxtUsuario.Text, patronRut))
            {
                MessageBox.Show("Debe ingresar rut o formato incorrecto");
            }
            else if (!Regex.IsMatch(TxtContrasena.Text, patronRut))
            {
                MessageBox.Show("Debe ingresar contraseña o formato correto");
            }
            else
            {
                estaOk = true;
            }
            return estaOk;
        }
        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento no esta disponible esta acción solicite en caja un cambio de clave presentando su carnet, lamentamos las molestias");
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado sin puntos ni guiones
            string identificacion = TxtUsuario.Text.Replace(".", "").Replace("-", "");

            // Verificar si el texto ingresado es válido
            if (IdentificacionValida(identificacion))
            {
                // Dar formato a la identificación con puntos y guión
                string identificacionFormateada = FormatearIdentificacion(identificacion);

                // Mostrar la identificación formateada en el campo de texto
                TxtUsuario.Text = identificacionFormateada;

                // Posicionar el cursor al final del texto
                TxtUsuario.SelectionStart = TxtUsuario.Text.Length;
            }
        }
        private bool IdentificacionValida(string identificacion)
        {
            // Aquí puedes agregar la lógica de validación de la identificación
            // y retornar true si es válida, o false si no lo es.
            // Puedes utilizar algoritmos y expresiones regulares para esto.
            // Dejo un ejemplo sencillo de validación:

            // Verificar que la identificación tenga al menos un dígito
            return !string.IsNullOrEmpty(identificacion);
        }

        private string FormatearIdentificacion(string identificacion)
        {
            // Insertar puntos y guión en la identificación
            if (identificacion.Length > 1)
            {
                return identificacion.Substring(0, identificacion.Length - 1)
                    .Reverse()
                    .Select((c, i) => (i != 0 && i % 3 == 0) ? $"{c}." : c.ToString())
                    .Aggregate((a, b) => b + a) + "-" + identificacion[identificacion.Length - 1];
            }
            else
            {
                return identificacion; // Retornar identificación sin formato si la longitud es menor a 2
            }
        }

    }
}
