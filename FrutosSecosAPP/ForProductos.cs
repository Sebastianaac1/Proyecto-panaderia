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
    public partial class ForProductos : Form
    {
        public ForProductos()
        {
            InitializeComponent();
            CargaPrimera();
            //llenarTabla();
        }
        private void llenarTabla()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select * from Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }
        private void CargaPrimera()
        {
            string cadena = "SELECT * from Categoria";
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCategoria.Items.Add(lector["DescripcionCategoria"].ToString());

            }
            conexion.Cerrar();
        }
        private void GuardarVentas_Click(object sender, EventArgs e)
        {
            string categoria = this.cboCategoria.Text;
            int id = CargarIdProduct(categoria);

            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            
            string query = "INSERT INTO Producto (NombreProducto,ValorProducto,StockProducto,IDCategoria) VALUES (@nombre,@valor,@stock,@categoria)";
            SqlCommand cmd = new SqlCommand(query, conexion.conectarbd);
            cmd.Parameters.AddWithValue("@nombre", this.NombreP.Text);
            cmd.Parameters.AddWithValue("@valor", this.Precio.Text);
            cmd.Parameters.AddWithValue("@stock", this.Stock.Text);
            cmd.Parameters.AddWithValue("@categoria", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conexion.Cerrar();
            Limpiartabla();
            llenarTabla();
            Limpiar();
        }
        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string categoria = this.cboCategoria.Text;
            int id = CargarIdProduct(categoria);
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            //string query = "UPDATE Producto SET ValorProducto = @valor, NombreProducto = @nombre, StockProducto = @stock WHERE IDProducto=@ID";
            string cadena = ("UPDATE Producto SET IDCategoria ='"+id+"', StockProducto ='"+Stock.Text+"', ValorProducto ='"+Precio.Text +"', NombreProducto='"+NombreP.Text +"'where IDProducto='"+ CProducto.Text +"'");
            SqlCommand cmd = new SqlCommand(cadena, conexion.conectarbd);
            int cant;
            cant = cmd.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Actualizado");
                Limpiartabla();
                llenarTabla();
                Limpiar();
            }
            conexion.Cerrar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }
        private int CargarIdProduct(string categoria)
        {
            int id = 0;
            string cadena = ("Select IDCategoria from Categoria WHERE DescripcionCategoria = '" + categoria + "'");
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                id = int.Parse(lector["IDCategoria"].ToString());
            }
            conexion.Cerrar();
            return id;
        }
        private string CargarNOMBREProduct(int id)
        {
            string nombre="";
            string cadena = ("Select IDCategoria from Categoria WHERE DescripcionCategoria = '" + id + "'");
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                id = int.Parse(lector["DescripcionCategoria"].ToString());
            }
            conexion.Cerrar();
            return nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ForProductos_Load(object sender, EventArgs e)
        {

            llenarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CProducto.Text = dataGridView1.SelectedCells[0].Value.ToString();
            NombreP.Text = dataGridView1.SelectedCells[1].Value.ToString();
            //cboCategoria.Text = dataGridView1.SelectedCells[2].Value.ToString();
            Stock.Text = dataGridView1.SelectedCells[3].Value.ToString();
            Precio.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BorrarDato_Click(object sender, EventArgs e)
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string cadena = ("Delete From Producto where IDProducto ='" + CProducto.Text + "'");
            SqlCommand cmd = new SqlCommand(cadena, conexion.conectarbd);
            int cant;
            cant = cmd.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Producto Eliminado");
                Limpiartabla();
                llenarTabla();
                Limpiar();
            }
            conexion.Cerrar();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            CProducto.Clear();
            Precio.Clear();
            NombreP.Clear();
            Stock.Clear();
            cboCategoria.SelectedIndex = -1;
            dataGridView1.ClearSelection();
            
        }
        private void Limpiartabla()
        {
            dataGridView1.DataSource = "";
        }

        private void BorrarVentas_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiartabla();
        }
    }
}
