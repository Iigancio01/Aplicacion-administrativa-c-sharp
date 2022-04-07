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



namespace appPrimer
{
    public partial class NuevaFicha : Form
    {
        Dato d = new Dato();
        public NuevaFicha()
        {
            InitializeComponent();
            ActualizarDatosC();
        }

        
        ConexionBd conexion = new ConexionBd();
        

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente(txtCodigoCliente.Text, txtRunCliente.Text, txtNombreC.Text, txtApaterno.Text, txtAmaterno.Text, 
                                      txtDireccion.Text, txtCorreo.Text, txtCodcomuna.Text, txtFechaNacimientoC.Text, txtRutEmpleado.Text);
                d.GuardarCliente(cli);
                ActualizarDatosC();
                MessageBox.Show("La ficha ha sido guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar la ficha: "+ex.Message);
            }
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
    }
}
