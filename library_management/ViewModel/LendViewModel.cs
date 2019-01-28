﻿using library_management.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.ViewModel
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
