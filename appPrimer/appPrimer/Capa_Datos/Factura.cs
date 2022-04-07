using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPrimer.Capa_Datos
{
    public class Factura
    {
        private string nro_factura;
        private string precio_neto;
        private string iva;
        private string total_factura;
        private string fecha_factura;
        private string cod_cliente;
        private string metodo_pago;

        public Factura()
        {
            nro_factura = string.Empty;
            precio_neto = string.Empty;
            iva = string.Empty;
            total_factura = string.Empty;
            fecha_factura = string.Empty;
            cod_cliente = string.Empty;
            metodo_pago = string.Empty;
        }

        public Factura(string nro_fa, string pr_ne, string iv, string to_fa, string fe_fa, string co_cli, string me_pa)
        {
            nro_factura = nro_fa;
            precio_neto = pr_ne;
            iva = iv;
            total_factura = to_fa;
            fecha_factura = fe_fa;
            cod_cliente = co_cli;
            metodo_pago = me_pa;
        }

        public string Nro_factura { get => nro_factura; set => nro_factura = value; }
        public string Precio_neto { get => precio_neto; set => precio_neto = value; }
        public string Iva { get => iva; set => iva  = value; }
        public string Total_factura { get => total_factura; set => total_factura = value; }
        public string Fecha_factura { get => fecha_factura; set => fecha_factura = value; }
        public string Cod_cliente { get => cod_cliente; set => cod_cliente = value; }
        public string Metodo_pago { get => metodo_pago; set => metodo_pago = value; }
    }
}
