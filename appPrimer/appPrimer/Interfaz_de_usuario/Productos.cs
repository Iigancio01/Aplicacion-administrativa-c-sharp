using appPrimer.Conexion;
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


namespace appPrimer
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            ActualizarDatosP();
        }

        //Conexion con la base de datos
        ConexionBd conexion = new ConexionBd();

        //Con este metodo se actualiza el datagridview
        public void ActualizarDatosP()
        {
            string cadena = "Select * from Producto";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgProductos.DataSource = dt;


        }
    }
}
