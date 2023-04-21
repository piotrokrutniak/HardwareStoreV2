using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Enums
{
    public enum SignInStatus
    {
        Success,
        LockedOut,
        RequiresTwoFactorAuthentication,
        Failure
    }
}
