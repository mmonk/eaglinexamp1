﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace eaglinexamp1.Models
{
    public class CustomContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CustomContext() : base("name=CustomContext")
        {
            Database.SetInitializer<CustomContext>(new DropCreateDatabaseIfModelChanges<CustomContext>());
        }

        public System.Data.Entity.DbSet<eaglinexamp1.Models.Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<eaglinexamp1.Models.MenuGroup> MenuGroups { get; set; }

        public System.Data.Entity.DbSet<eaglinexamp1.Models.MenuItem> MenuItems { get; set; }
    }
}
