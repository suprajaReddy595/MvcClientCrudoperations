﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClientCrudoperations.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QualityStock { get; set; }
        public string Supplier { get; set; }
    }
    
}
