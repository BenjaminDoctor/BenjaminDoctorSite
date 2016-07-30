using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProfessionalApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProfessionalApp.DAL
{
    public class ContentContext : DbContext
    {
        public ContentContext() : base("SchoolContext")
        {
        }

        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}