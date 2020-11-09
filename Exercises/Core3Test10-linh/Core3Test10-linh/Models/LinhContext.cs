using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Core3Test10_linh.Models
{
    public class LinhContext:DbContext
    {
        public DbSet<Linh> Linhs { get; set; }

    }
}