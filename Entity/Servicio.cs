﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
       public  int CodigodeServicio {get;set;}
       public string NombreServicio {get; set;}
       public decimal SubTotal {get;set;}
       public decimal PorcentajeGanancia {get;set;}
       public decimal PrecioServicio {get;set;}
       
  
     public Servicio()
        {

        }

        public Servicio(int codigoservicio, string nombreservicio, decimal subTotal,decimal porcentajeGanancia,decimal precioServicio)
        { 
            CodigodeServicio = codigoservicio;
            NombreServicio = nombreservicio;
             SubTotal = subTotal;
        
            
        }

        
    }
}
