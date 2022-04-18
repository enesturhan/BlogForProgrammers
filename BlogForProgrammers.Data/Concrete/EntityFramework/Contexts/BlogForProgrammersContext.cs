﻿using BlogForProgrammers.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForProgrammers.Data.Concrete.EntityFramework.Contexts
{
    public class BlogForProgrammersContext:DbContext
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\\MSSQLLocalDB; Database = BlogForProgrammers; Trusted_Connection = True; MultipleActiveResultSets = true;");
        }


    }
}
