using appPrimer.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPrimer.Interfaz_de_usuario;
using System.Windows.Forms;
using appPrimer.Capa_Datos;


namespace appPrimer
{
    public class Dato
    {
        ConexionBd conexion = new ConexionBd();
        

        public void GuardarCliente(Cliente cli)
        {
            conexion.Abrir();
            string cadena = "Insert into Cliente " +
                       "(cod_cliente, rut, nombre, apellido_paterno, apellido_materno, direccion, correo_cliente,fecha_nacimiento_c, Comuna_cod_comuna, Empleado_rut_empleado )" +
                "values (@cod_cliente, @rut, @nombre, @apellido_paterno, @apellido_materno, @direccion, @correo_cliente, @fecha_nacimiento_c, @Comuna_cod_comuna, @Empleado_rut_empleado )";

            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);

            comando.Parameters.AddWithValue("@cod_cliente", cli.Codigo_cliente);
            comando.Parameters.AddWithValue("@rut", cli.Rut);
            comando.Parameters.AddWithValue("@nombre", cli.Nombre);
            comando.Parameters.AddWithValue("@apellido_paterno", cli.Apellido_paterno);
            comando.Parameters.AddWithValue("@apellido_materno", cli.Apellido_materno);
            comando.Parameters.AddWithValue("@direccion", cli.Direccion);
            comando.Parameters.AddWithValue("@correo_cliente", cli.Correo_cliente);
            comando.Parameters.AddWithValue("@fecha_nacimiento_c", cli.Fecha_nacimiento_c);
            comando.Parameters.AddWithValue("@Comuna_cod_comuna", cli.Cod_comuna);
            comando.Parameters.AddWithValue("@Empleado_rut_empleado", cli.Rut_empleado);

            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }
        
        public void ModificarCliente(Cliente cli)
        {
            conexion.Abrir();
            string cadena = "Update Cliente set " +
                "nombre=@nombre, apellido_paterno=@apellido_paterno, apellido_materno=@apellido_materno, direccion=@direccion, correo_cliente=@correo_cliente," +
                "fecha_nacimiento_c=@fecha_nacimiento_c, Comuna_cod_comuna=@Comuna_cod_comuna, Empleado_rut_empleado=@Empleado_rut_empleado where rut=@rut";
            
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);

            comando.Parameters.AddWithValue("@cod_cliente", cli.Codigo_cliente);
            comando.Parameters.AddWithValue("@rut", cli.Rut);
            comando.Parameters.AddWithValue("@nombre", cli.Nombre);
            comando.Parameters.AddWithValue("@apellido_paterno", cli.Apellido_paterno);
            comando.Parameters.AddWithValue("@apellido_materno", cli.Apellido_materno);
            comando.Parameters.AddWithValue("@direccion", cli.Direccion);
            comando.Parameters.AddWithValue("@correo_cliente", cli.Correo_cliente);
            comando.Parameters.AddWithValue("@fecha_nacimiento_c", cli.Fecha_nacimiento_c);
            comando.Parameters.AddWithValue("@Comuna_cod_comuna", cli.Cod_comuna);
            comando.Parameters.AddWithValue("@Empleado_rut_empleado", cli.Rut_empleado);

            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }

        public void GuardarBoleta(Boleta bole)
        {
            conexion.Abrir();
            string cadena = "Insert into boleta" +
                            "(nro_boleta, total_boleta, fecha_boleta, Cliente_cod_cliente, Metodo_pago_cod_tipo_pago) " +
                            "values(@nro_boleta, @total_boleta, @fecha_boleta, @Cliente_cod_cliente, @Metodo_pago_cod_tipo_pago) ";

            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);

            comando.Parameters.AddWithValue("@nro_boleta", bole.Nro_boleta);
            comando.Parameters.AddWithValue("@total_boleta", bole.Total_boleta);
            comando.Parameters.AddWithValue("@fecha_boleta", bole.Fecha_boleta);
            comando.Parameters.AddWithValue("@Cliente_cod_cliente", bole.Cod_cliente);
            comando.Parameters.AddWithValue("@Metodo_pago_cod_tipo_pago", bole.Metodo_pago);

            comando.ExecuteNonQuery();
            conexion.Cerrar();

        }   

        public void GuardarFactura(Factura fac)
        {
            conexion.Abrir();
            string cadena = "Insert into Factura" +
                "(nro_factura, precio_neto, iva, total_factura, fecha_factura, Cliente_cod_cliente, Metodo_pago_cod_tipo_pago)" +
                "values(@nro_factura, @precio_neto, @iva, @total_factura, @fecha_factura, @Cliente_cod_cliente, @Metodo_pago_cod_tipo_pago)";

            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);

            comando.Parameters.AddWithValue("@nro_factura", fac.Nro_factura);
            comando.Parameters.AddWithValue("@precio_neto", fac.Precio_neto);
            comando.Parameters.AddWithValue("@iva", fac.Iva);
            comando.Parameters.AddWithValue("@total_factura", fac.Total_factura);
            comando.Parameters.AddWithValue("@fecha_factura", fac.Fecha_factura);
            comando.Parameters.AddWithValue("@Cliente_cod_cliente", fac.Cod_cliente);
            comando.Parameters.AddWithValue("@Metodo_pago_cod_tipo_pago", fac.Metodo_pago);

            comando.ExecuteNonQuery();
            conexion.Cerrar();

        }
    }
}
