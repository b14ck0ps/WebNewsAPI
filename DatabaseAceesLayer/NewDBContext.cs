using DatabaseAceesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAceesLayer
{
    public class NewDBContext : DbContext
    {
        public NewDBContext() : base("name=NewsDB") { }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}