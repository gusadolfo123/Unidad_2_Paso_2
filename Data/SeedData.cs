using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_2_Paso_2.Models;

namespace Unidad_2_Paso_2.Data
{
    public class SeedData
    {
        public static List<Product> SeedProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Zapatos", Category = "A", Stock = 30, UnitPrice = 160000 },
                new Product { Id = 2, Name = "Saco", Category = "A", Stock = 20, UnitPrice = 85000 },
                new Product { Id = 3, Name = "Camisa", Category = "A", Stock = 100, UnitPrice = 30000 },
                new Product { Id = 4, Name = "XBOX One", Category = "C", Stock = 10, UnitPrice = 500000 },
                new Product { Id = 5, Name = "Nintendo 3DS", Category = "C", Stock = 5, UnitPrice = 450000 },
                new Product { Id = 6, Name = "Audifonos", Category = "B", Stock = 60, UnitPrice = 20000 },
            };
        }
    }
}
