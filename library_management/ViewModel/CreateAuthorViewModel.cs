﻿using library_management.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.ViewModel
{
    public class CreateAuthorViewModel
    {
        public Author Author { get; set; }
        public string Referer { get; set; }
    }
}