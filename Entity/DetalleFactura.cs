using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public DetalleFactura( Servicio servicio,int cantidadServicios )
        {
            Servicio = servicio;

            Cantidad = cantidadServicios;
            
        }

        public string Codigo { get; set; }
        public string idServicio { get; set; }
        public string IdFactura { get; set; }
        public Factura Factura { get; set; }

        public Servicio Servicio { get; set; }
        public int Cantidad { get; set; }

        public decimal ValorDescuento { get; set; }

 
        public decimal ValorsubTotal {

            get { return Servicio.PrecioServicio * Cantidad; }

            set { }
        }
       

    }
}
