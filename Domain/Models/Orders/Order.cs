using HardwareStoreV2.Domain.Enums;
using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Orders
{
    public class Order : IModelBase
    {
        public int Id { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
