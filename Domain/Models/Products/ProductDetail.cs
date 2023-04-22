using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Products
{
    public class ProductDetail : IModelBase
    {
        public int Id { get; set; }
        public int DetailTypeId { get; set; }
        public DetailType DetailType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
