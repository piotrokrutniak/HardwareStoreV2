using HardwareStoreV2.Domain.Models.Bases;
using HardwareStoreV2.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Builds
{
    public class BuildItem : IModelBase
    {
        public int Id { get; set; }
        public int BuildId { get; set; }
        public Build Build { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
