using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Paso_2.Models
{
    public class Product
    {
        public int Id { get; set; } 
        
        [DisplayName("Nombre")]        
        public string Name { get; set; }

        [DisplayName("Precio")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Categoria")]
        public string Category { get; set; }

        [DisplayName("Stock")]
        public int Stock { get; set; }

        [DisplayName("IVA")]
        public decimal Tax
        {
            get 
            {
                switch (Category)
                {
                    case "A":
                        return UnitPrice * 0.15M;
                    case "B":
                        return UnitPrice * 0.16M;
                    case "C":
                        return UnitPrice * 0.16M;
                    default:
                        return 0;
                }
            }            
        }
    }
}
