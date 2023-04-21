using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Identity
{
    public sealed class ApplicationUserLoginInfo
    {
        public string LoginProvider
        {
            get;
            set;
        }

        public string ProviderKey
        {
            get;
            set;
        }

        public ApplicationUserLoginInfo(string loginProvider, string providerKey)
        {
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
        }
    }
}
