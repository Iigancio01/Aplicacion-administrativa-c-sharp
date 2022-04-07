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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
            ActualizarDatosC();
        }

        ConexionBd conexion = new ConexionBd();

        public void ActualizarDatosC()
        {
            string cadena = "Select * from Cliente";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvClientes.DataSource = dt;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
