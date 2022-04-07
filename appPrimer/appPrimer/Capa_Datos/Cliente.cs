using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPrimer.Capa_Datos
{
    public class Cliente
    {
        private string codigo_cliente;
        private string rut;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string direccion;
        private string correo_cliente;
        private string cod_comuna;
        private string fecha_nacimiento_c;
        private string rut_empleado;


      

        public  Cliente()
        {
            codigo_cliente = string.Empty;
            rut = string.Empty;
            nombre = string.Empty;
            apellido_paterno = string.Empty;
            apellido_materno = string.Empty;
            direccion = string.Empty;
            correo_cliente = string.Empty;
            cod_comuna = string.Empty;
            fecha_nacimiento_c = string.Empty;
            rut_empleado = string.Empty;
        }

        public Cliente(string cod, string ru, string no, string app, string apm, string dir, string cor, string codc, string fnc, string re )
        {
            codigo_cliente = cod;
            rut = ru;
            nombre = no;
            apellido_paterno = app;
            apellido_materno = apm;
            direccion = dir;
            correo_cliente = cor;
            cod_comuna = codc;
            fecha_nacimiento_c = fnc;
            rut_empleado = re;
        }

        public string Codigo_cliente { get => codigo_cliente; set => codigo_cliente = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
        public string Cod_comuna { get => cod_comuna; set => cod_comuna = value; }
        public string Fecha_nacimiento_c { get => fecha_nacimiento_c; set => fecha_nacimiento_c = value; }
        public string Rut_empleado { get => rut_empleado; set => rut_empleado = value; }


    }
}
