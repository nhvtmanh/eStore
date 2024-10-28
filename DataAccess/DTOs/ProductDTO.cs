using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class ProductDTO
    {
        public int? CategoryId { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal? Weight { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitsInStock { get; set; }
    }
}
