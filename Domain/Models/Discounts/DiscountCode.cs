using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Discounts
{
    public class DiscountCode : IDiscountBase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime Activation { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
