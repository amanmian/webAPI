using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApi.Models
{
    public class DetailContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //   public DbSet<NameStateCity> Names { get; set; }
        //  public DbSet<Course> Courses { get; set; }
        public DetailContext() : base("Aman")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("web");
            base.OnModelCreating(modelBuilder);
        }

    }   }