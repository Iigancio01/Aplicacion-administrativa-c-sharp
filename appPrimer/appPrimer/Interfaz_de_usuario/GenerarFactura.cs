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
    public partial class GenerarFactura : Form
    {
        public GenerarFactura()
        {
            InitializeComponent();
            LlenarCombobox();

            Activar();
            Activar1();
            Activar2();
            Activar3();
            Activar4();
        }

        ConexionBd conexion = new ConexionBd();
        Dato d = new Dato();
        public void LlenarCombobox()
        {
            conexion.Abrir();

            string cadena = "select nombre_producto from Producto";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cmbProductos.Items.Add(lector["nombre_producto"].ToString());
                cmbProductos1.Items.Add(lector["nombre_producto"].ToString());
                cmbProductos2.Items.Add(lector["nombre_producto"].ToString());
                cmbProductos3.Items.Add(lector["nombre_producto"].ToString());
                cmbProductos4.Items.Add(lector["nombre_producto"].ToString());

            }
            lector.Close();

            conexion.Cerrar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ActualizarPrecio();

            int total = 0;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int totalp = 0;
            int totalsin = 0;
            int ivatotal = 0;

            if (txtCantidad.Text != string.Empty)
            {
                total = int.Parse(lbPrecio.Text) * int.Parse(txtCantidad.Text);
                lbTotalp.Text = total.ToString();
            }
            if (txtCantidad1.Text != string.Empty)
            {
                total1 = int.Parse(lbPrecio1.Text) * int.Parse(txtCantidad1.Text);
                lbTotalp1.Text = total1.ToString();
            }
            if (txtCantidad2.Text != string.Empty)
            {
                total2 = int.Parse(lbPrecio2.Text) * int.Parse(txtCantidad2.Text);
                lbTotalp2.Text = total2.ToString();
            }
            if (txtCantidad3.Text != string.Empty)
            {
                total3 = int.Parse(lbPrecio3.Text) * int.Parse(txtCantidad3.Text);
                lbTotalp3.Text = total3.ToString();
            }
            if (txtCantidad4.Text != string.Empty)
            {
                total4 = int.Parse(lbPrecio4.Text) * int.Parse(txtCantidad4.Text);
                lbTotalp4.Text = total4.ToString();
            }

            totalp = total + total1 + total2 + total3 + total4;

            lbTotal.Text = totalp.ToString();

            btnGenerarBoleta.Enabled = true;

            totalsin = (totalp * 81)/100;

            lbTotalsiniva.Text = totalsin.ToString();

            ivatotal = (totalp * 19) / 100;

            lbIva.Text = ivatotal.ToString();
        }

        public void ActualizarPrecio()
        {
            conexion.Abrir();

            if (cmbProductos.Enabled == true)
            {
                string cadena = "Select precio_producto from Producto where nombre_producto=@nombre_producto";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.Parameters.AddWithValue("@nombre_producto", cmbProductos.SelectedItem);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lbPrecio.Text = registro["precio_producto"].ToString();

                }
                registro.Close();

            }

            if (cmbProductos1.Enabled == true)
            {
                string cadena = "Select precio_producto from Producto where nombre_producto=@nombre_producto";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.Parameters.AddWithValue("@nombre_producto", cmbProductos1.SelectedItem);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {

                    lbPrecio1.Text = registro["precio_producto"].ToString();

                }
                registro.Close();

            }

            if (cmbProductos2.Enabled == true)
            {
                string cadena = "Select precio_producto from Producto where nombre_producto=@nombre_producto";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.Parameters.AddWithValue("@nombre_producto", cmbProductos2.SelectedItem);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {

                    lbPrecio2.Text = registro["precio_producto"].ToString();

                }
                registro.Close();

            }
            if (cmbProductos3.Enabled == true)
            {
                string cadena = "Select precio_producto from Producto where nombre_producto=@nombre_producto";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.Parameters.AddWithValue("@nombre_producto", cmbProductos3.SelectedItem);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {

                    lbPrecio3.Text = registro["precio_producto"].ToString();

                }
                registro.Close();

            }
            if (cmbProductos4.Enabled == true)
            {
                string cadena = "Select precio_producto from Producto where nombre_producto=@nombre_producto";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.Parameters.AddWithValue("@nombre_producto", cmbProductos4.SelectedItem);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {

                    lbPrecio4.Text = registro["precio_producto"].ToString();
                }
                registro.Close();

            }


            conexion.Cerrar();
        }

        public void Activar()
        {
            if (cbProducto.Checked)
            {
                cmbProductos.Enabled = true;
                txtCantidad.Enabled = true;
                lbPrecio.Enabled = true;
                lbTotalp.Enabled = true;
            }
            else
            {
                cmbProductos.Enabled = false;
                txtCantidad.Enabled = false;
                lbPrecio.Enabled = false;
                lbTotalp.Enabled = false;
                cmbProductos.Text = string.Empty;
            }

        }

        public void Activar1()
        {
            if (cbProducto1.Checked)
            {
                cmbProductos1.Enabled = true;
                txtCantidad1.Enabled = true;
                lbPrecio1.Enabled = true;
                lbTotalp1.Enabled = true;
            }
            else
            {
                cmbProductos1.Enabled = false;
                txtCantidad1.Enabled = false;
                lbPrecio1.Enabled = false;
                lbTotalp1.Enabled = false;
                cmbProductos1.Text = string.Empty;
            }
        }

        public void Activar2()
        {
            if (cbProducto2.Checked)
            {
                cmbProductos2.Enabled = true;
                txtCantidad2.Enabled = true;
                lbPrecio2.Enabled = true;
                lbTotalp2.Enabled = true;
            }
            else
            {
                cmbProductos2.Enabled = false;
                txtCantidad2.Enabled = false;
                lbPrecio2.Enabled = false;
                lbTotalp2.Enabled = false;
                cmbProductos2.Text = string.Empty;
            }
        }

        public void Activar3()
        {
            if (cbProducto3.Checked)
            {
                cmbProductos3.Enabled = true;
                txtCantidad3.Enabled = true;
                lbPrecio3.Enabled = true;
                lbTotalp3.Enabled = true;
            }
            else
            {
                cmbProductos3.Enabled = false;
                txtCantidad3.Enabled = false;
                lbPrecio3.Enabled = false;
                lbTotalp3.Enabled = false;
                cmbProductos3.Text = string.Empty;
            }
        }

        public void Activar4()
        {
            if (cbProducto4.Checked)
            {
                cmbProductos4.Enabled = true;
                txtCantidad4.Enabled = true;
                lbPrecio4.Enabled = true;
                lbTotalp4.Enabled = true;
            }
            else
            {
                cmbProductos4.Enabled = false;
                txtCantidad4.Enabled = false;
                lbPrecio4.Enabled = false;
                lbTotalp4.Enabled = false;
                cmbProductos4.Text = string.Empty;
            }
        }

        private void cbProducto_CheckedChanged(object sender, EventArgs e)
        {
            Activar();
        }

        private void cbProducto1_CheckedChanged(object sender, EventArgs e)
        {
            Activar1();
        }

        private void cbProducto2_CheckedChanged(object sender, EventArgs e)
        {
            Activar2();
        }

        private void cbProducto3_CheckedChanged(object sender, EventArgs e)
        {
            Activar3();
        }

        private void cbProducto4_CheckedChanged(object sender, EventArgs e)
        {
            Activar4();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sandbox.flow.cl/app/web/pagarBtnPago.php?token=i17sqgi");
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            try
            {
                Factura fac = new Factura(txtNrofactura.Text, lbTotalsiniva.Text, lbIva.Text, lbTotal.Text, txtFecha.Text,txtCodcliente.Text, txtTipopago.Text );
                d.GuardarFactura(fac);
                btnPagar.Enabled = true;
                MessageBox.Show("La boleta fue creada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La boleta no pudo ser creada:" + ex.Message);
            }

        }
    }
}
