﻿using BlogForProgrammers.Data.Abstract;
using BlogForProgrammers.Entities.Concrete;
using BlogForProgrammers.Shared.Data.Abstract;
using BlogForProgrammers.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForProgrammers.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
