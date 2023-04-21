using HardwareStoreV2.Domain.Enums;
using HardwareStoreV2.Domain.Models.Bases;
using HardwareStoreV2.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Discounts
{
    public class ProductDiscount : IDiscountBase
    {
        public int Id { get; set; }
        public int DiscountAmount { get; set; }
        public int TargetId { get; set; }
        public DiscountTarget DiscountTarget { get; set; }
        public DateTime Activation { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
