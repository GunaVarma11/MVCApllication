using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _6th_feb_school_database_project.Data
{
    public class ClassDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClassDbContext() : base("name=ClassDbContext")
        {
        }

        public System.Data.Entity.DbSet<_6th_feb_school_database_project.Models.Class> Classes { get; set; }
    }
}
