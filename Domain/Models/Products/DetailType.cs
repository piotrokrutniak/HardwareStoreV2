using HardwareStoreV2.Domain.Enums;
using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Products
{
    public class DetailType : IModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DetailStyle DetailStyle { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
