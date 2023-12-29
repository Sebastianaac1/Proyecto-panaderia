using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrutosSecosAPP
{
    
        class Conexion_Bas_Datos
        {
            string cadena = "Data Source=DESKTOP-QPT9IIN\\SQLEXPRESS;Initial Catalog =EnsayoBasededatos3;Integrated Security = true";
            public SqlConnection conectarbd = new SqlConnection();

            public Conexion_Bas_Datos()
            {
                conectarbd.ConnectionString = cadena;
            }
            public void Abrir()
            {
                try
                {
                    conectarbd.Open();
                    Console.WriteLine("Conexión Abierta");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al abrir la base de datos " + ex.Message);
                }
            }
            public void Cerrar()
            {
                conectarbd.Close();
            }

        }
    
}
