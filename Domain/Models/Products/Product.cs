using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Products
{
    public class Product : IModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public List<ProductDetail> Details { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
