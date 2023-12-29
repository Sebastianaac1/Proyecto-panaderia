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
    public partial class ForPunto : Form
    {
        string idp, idc, nombre, stock;
        string valor;
        string idp2, idc2, nombre2, stock2;
        string valor2;
        int poc;
        public ForPunto()
        {
            InitializeComponent();
            CargaPrimera();
            CargarVendedor();
            CargarCliente();
            CargarMetodo();
            cargartarjeta();
            CargarDocumento();
            CargarSucursal();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ensayoBasededatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select * from Producto,Categoria";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Cerrar();
        }

        private void Consulta2()
        {
            string categoria = this.comboBox3.Text;
            int id = CargarIdProduct(categoria);
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string consulta = "select * from Producto where IDCategoria like ('" + id + "%')";
            //conexion.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CargarBoleta();
            CargarBoleta2();
        }
        private void Consulta()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string consulta = "select * from Producto where NombreProducto like ('" + textBox1.Text + "%')";
            //conexion.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Cerrar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta2();
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
                comboBox3.Items.Add(lector["DescripcionCategoria"].ToString());

            }
            conexion.Cerrar();
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
        public void TabladeAgregarDatos(DataGridView fila1a)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            idp = dataGridView1.SelectedCells[0].Value.ToString();
            nombre = dataGridView1.SelectedCells[1].Value.ToString();
            idc = dataGridView1.SelectedCells[2].Value.ToString();
            stock = dataGridView1.SelectedCells[3].Value.ToString();
            //double.TryParse(dataGridView1.SelectedCells[4].Value.ToString(), out valor);
            valor = dataGridView1.SelectedCells[4].Value.ToString();

        }
        private void CargarBoleta()
        {
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            string relleno = "select * from Producto where IDProducto ='"+ idp+"'";
            SqlDataAdapter adaptador = new SqlDataAdapter(relleno, conexion.conectarbd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            //dataGridView2.DataSource = dt;

            conexion.Cerrar();
        }
        private void CargarBoleta2()
        {
            dataGridView3.Rows.Add(idp, nombre,valor,idc);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CargarMetodo()
        {
            comboBox2.Items.Add("Efectivo");
            comboBox2.Items.Add("Tarjeta");
        }
        private void CargarDocumento()
        {
            comboBox1.Items.Add("Factura");
            comboBox1.Items.Add("Boleta");
        }
        private void cargartarjeta()
        {
            string item = comboBox2.Text;
            if (item == "Tarjeta")
            {
                CargarTarjetas();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargartarjeta();
        }

        private void CargarVendedor()
        {
            string cadena = "SELECT * from Vendedor";
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox4.Items.Add(lector["RUTVendedor"].ToString());

            }
            conexion.Cerrar();
        }
        private void CargarSucursal()
        {
            string cadena = "SELECT * from Sucursal";
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox7.Items.Add(lector["DireccionSucursal"].ToString());

            }
            conexion.Cerrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubirVenta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.RemoveAt(poc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalventa();
        }

        public void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridView3.CurrentRow.Index;
        }

        private int CargarIdSucursal(string sucursal)
        {
            int id = 0;
            string cadena = ("Select IDSucursal from Categoria WHERE DireccionSucursal = '" + sucursal + "'");
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
        private void CargarCliente()
        {
            string cadena = "SELECT * from Cliente";
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox5.Items.Add(lector["RUTCliente"].ToString());

            }
            conexion.Cerrar();
        }
        private void CargarTarjetas()
        {
            string item = comboBox5.Text;
            string cadena = "SELECT * from Tarjeta,Cliente where RUTCliente='"+ item +"'";
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //comboBox6.Items.Add(lector["NumerodeTarjeta"].ToString());

            }
            conexion.Cerrar();
        }
        private void SubirVenta()
        {
            DateTime todo=DateTime.Now;
            string fecha = todo.ToString("MM/dd/yyyy");
            string hora = todo.ToString("hh:mm:ss");
            string sucursal = this.comboBox7.Text;
            int id = CargarIdProduct(sucursal);
            //double total=totalventa();
            Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
            conexion.Abrir();

            string query = "INSERT INTO Venta (IDSucursal,RUTVendedor,RUTCliente,PesoVenta,NumerodePedido,FechaVenta,TotalVenta,HoraVenta) VALUES (@sucursal,@vendedor,@cliente,@peso,@numero,@fecha,@total,@hora)";
            SqlCommand cmd = new SqlCommand(query, conexion.conectarbd);
            cmd.Parameters.AddWithValue("@sucursal",id);
            cmd.Parameters.AddWithValue("@vendedor", comboBox4.Text);
            cmd.Parameters.AddWithValue("@cliente", comboBox5.Text);
            cmd.Parameters.AddWithValue("@peso", id);
            cmd.Parameters.AddWithValue("@numero", "");
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@total", id);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conexion.Cerrar();
        }
        private void totalventa()
        {
            double total = 0;
            double producto = 0;
            int cantidad = 0;
            foreach(DataGridViewRow row in dataGridView3.Rows)
            {
                total += Convert.ToDouble(row.Cells["ValordelP"].Value);
                //cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                //total = producto * cantidad;
            }
            Total.Text = total.ToString();
        }
    }

}
