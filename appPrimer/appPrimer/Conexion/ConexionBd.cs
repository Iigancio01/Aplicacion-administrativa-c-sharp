using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appPrimer.Conexion
{
    public class ConexionBd
    {
        string cadena = "Data source=IGNACIOWO-PC\\SQLEXPRESS;Initial Catalog=AppDigitalGaming1; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta con exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            conectarbd.Close();
        }
    }
}
