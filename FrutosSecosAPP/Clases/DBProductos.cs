using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrutosSecosAPP.Clases
{
    public class DBProductos
    {
        private int IDProdcuto;
        private string nombrepro;
        private int stockpro;
        private decimal valorpro;
        //private byte[] imagen;

        public int Id_pro { get => IDProdcuto; set => IDProdcuto = value; }
        public string Nombrepro { get => nombrepro; set => nombrepro = value; }
        public int Stockpro { get => stockpro; set => stockpro = value; }
        public decimal Valorpro { get => valorpro; set => valorpro = value; }
        //public byte[] Imagen { get => imagen; set => imagen = value; }

        Conexion_Bas_Datos conexion = new Conexion_Bas_Datos();
        
        /*public void LlenarBoton(FlowLayoutPanel Contenedor)
        {
            conexion.Abrir();
            string transactSql = "Select * from Productos";
            SqlCommand comando = new SqlCommand(transactSql, conexion.conectarbd);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                IDProdcuto = Convert.ToInt32(reader[0]);
                nombrepro = reader[4].ToString();
                valorpro = Convert.ToDecimal(reader[3]);
                stockpro = Convert.ToInt32(reader[2]);
                //Imagen = reader[6].ToString(); 

                BotonProducto btn =  new BotonProducto();
                btn.Id = IDProdcuto;
                btn.NameProducto = nombrepro;
                btn.Precio = "$" + valorpro.ToString("N2");
                btn.Stock = stockpro;
                //MemoryStream ms =new MemoryStream(Imagen);
                //btn.ImageProducto = Imagen.FromStream(ms);
                //btn.ImageProducto = pictureBox.;

                Contenedor.Controls.Add(btn);


            }
            conexion.Cerrar();
            
        }*/
        

        
    }
}
