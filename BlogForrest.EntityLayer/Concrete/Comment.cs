﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForrest.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Detail { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }
    }
}
