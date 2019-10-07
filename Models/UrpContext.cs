using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WwcUrpApi.Models
{
    public class UrpContext : DbContext
    {
        public UrpContext(DbContextOptions<UrpContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
