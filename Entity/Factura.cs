using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {

        public Factura(Cliente cliente, Empleado empleado) {
            Cliente = cliente;
            Empleado = empleado;

        }
        public string IdEmpleado { get; set; }
        public string IdCliente {get; set;}
        public string NroComprobante {get; set;}
         public DateTime FechaEmision { get; set; }

        public decimal Subtotal { get { return detallesFactura.Sum(d => d.ValorsubTotal); } }

        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public string TipoDocumento { get; set; }
       
        public List<DetalleFactura> detallesFactura { get; set; }
       
        public Servicio servicio { get; set; }

        public DetalleFactura AgregarDetalleFactura(int idfactura, decimal valorsubTotal)
        {

            DetalleFactura detalleFactura = new DetalleFactura( idfactura, valorsubTotal);
            detalleFactura.Factura = this ;
            Idfactura = idfactura;
            detallesFactura.Add(detalleFactura);
            return detalleFactura;
        }
   
        public decimal Descuento

        {
        
            get { return detallesFactura.Sum(d => d.ValorDescuento); }

        }


        public decimal Total {
            get => Subtotal - Descuento;

        }




    }
}


   
