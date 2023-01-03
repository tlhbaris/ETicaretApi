﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Domain.Entities.Common
{
    public class BaseEntity
    {

        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
