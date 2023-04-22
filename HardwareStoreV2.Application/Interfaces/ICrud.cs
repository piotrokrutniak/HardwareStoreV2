using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareStoreV2.Domain.Models.Bases;

namespace HardwareStoreV2.Application.Interfaces
{
    public interface ICrud
    {
        public void Create(IModelBase model)
        {

        }
        public void Read(IModelBase model)
        {

        }
        public void Update(int id, IModelBase model)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
