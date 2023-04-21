using HardwareStoreV2.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Builds
{
    public class Build : IModelBase
    {
        public int Id { get; set; }
        public List<BuildItem> BuildItems { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
