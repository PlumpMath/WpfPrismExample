using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleModel
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
