﻿using BlogForrest.DataAccessLayer.Abstract;
using BlogForrest.DataAccessLayer.Context;
using BlogForrest.DataAccessLayer.Repositories;
using BlogForrest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForrest.DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public EfBlogDal(BlogContext context) : base(context)
        {
        }
    }
}
