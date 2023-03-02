﻿using BlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Abstract
{
    public interface IBlogDAL : IGenericDAL<Blog>
    {
        List<Blog> GetListWithCategory();
    }
}
