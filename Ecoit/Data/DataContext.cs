using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecoit.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecoit.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Formation> Formation { get; set; }
    }
}