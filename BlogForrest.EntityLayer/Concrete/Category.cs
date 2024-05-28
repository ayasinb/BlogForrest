﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForrest.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName  { get; set; } 
        public List<Blog> Blogs { get; set; }
    }
}
