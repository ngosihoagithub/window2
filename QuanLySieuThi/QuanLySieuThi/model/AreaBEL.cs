﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.model
{
    internal class AreaBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CustomerBEL> Customers { get; set; }
    }
}
