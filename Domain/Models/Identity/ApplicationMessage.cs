﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreV2.Domain.Models.Identity
{
    public class ApplicationMessage
    {
        public virtual string Body
        {
            get;
            set;
        }

        public virtual string Destination
        {
            get;
            set;
        }

        public virtual string Subject
        {
            get;
            set;
        }

    }
}
