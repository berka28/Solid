﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interfaces
{
    public interface IStandardService
    {
        public string Name { get; set; }

        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}
