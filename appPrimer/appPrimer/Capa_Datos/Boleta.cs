using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPrimer.Capa_Datos
{
    public class Boleta
    {
        private string nro_boleta;
        private string total_boleta;
        private string fecha_boleta;      
        private string cod_cliente;
        private string metodo_pago;

        public Boleta()
        {
            nro_boleta = string.Empty;
            total_boleta = string.Empty;
            fecha_boleta = string.Empty; 
            cod_cliente = string.Empty;
            metodo_pago = string.Empty;
        }

        public Boleta(String nro_bo, string tbole, string fe_bo, string cod_cli, string me_pa)
        {
            nro_boleta = nro_bo;
            total_boleta = tbole;
            fecha_boleta = fe_bo;    
            cod_cliente = cod_cli;
            metodo_pago = me_pa;
        }

        public string Nro_boleta { get => nro_boleta; set => nro_boleta = value; }
        public string Total_boleta { get => total_boleta; set => total_boleta = value; }
        public string Fecha_boleta { get => fecha_boleta; set => fecha_boleta = value; }  
        public string Cod_cliente { get => cod_cliente; set => cod_cliente = value; }
        public string Metodo_pago { get => metodo_pago; set => metodo_pago = value; }
    }
}
