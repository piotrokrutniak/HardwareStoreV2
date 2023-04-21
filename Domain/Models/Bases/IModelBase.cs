using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Bases
{
    public interface IModelBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
