using appPrimer.Capa_Datos;
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

namespace appPrimer.Interfaz_de_usuario
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
            ActualizarDatosC();
        }

        Dato d = new Dato();
        int poc;
        ConexionBd conexion = new ConexionBd();

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvClientes.CurrentRow.Index;

            txtRunCliente.Text = dgvClientes[0,poc].Value.ToString();
            txtNombreC.Text = dgvClientes[1, poc].Value.ToString();
            txtApaterno.Text = dgvClientes[2, poc].Value.ToString();
            txtAmaterno.Text = dgvClientes[3, poc].Value.ToString();
            txtDireccion.Text = dgvClientes[4, poc].Value.ToString();
            txtCorreo.Text = dgvClientes[5, poc].Value.ToString();
            txtCodigoCliente.Text = dgvClientes[6, poc].Value.ToString();
            txtFechaNacimientoC.Text = dgvClientes[7, poc].Value.ToString();
            txtCodcomuna.Text = dgvClientes[8, poc].Value.ToString();
            txtRutEmpleado.Text = dgvClientes[9, poc].Value.ToString();
        }

        public void ActualizarDatosC()
        {
            string cadena = "Select * from Cliente";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvClientes.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(txtCodigoCliente.Text, txtRunCliente.Text, txtNombreC.Text, txtApaterno.Text, txtAmaterno.Text,
                                       txtDireccion.Text, txtCorreo.Text, txtCodcomuna.Text, txtFechaNacimientoC.Text, txtRutEmpleado.Text);
            d.ModificarCliente(cli);
            ActualizarDatosC();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRunCliente.Text = "";
            txtCodigoCliente.Text = "";
            txtNombreC.Text = "";
            txtDireccion.Text = "";
            txtApaterno.Text = "";
            txtAmaterno.Text = "";
            txtFechaNacimientoC.Text = "";
            txtCodcomuna.Text = "";
            txtRutEmpleado.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
