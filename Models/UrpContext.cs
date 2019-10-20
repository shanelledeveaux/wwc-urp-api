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
        public DbSet<Accomplishment> Accomplishment { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Employment> Employment { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<OtherAssociation> OtherAssociation { get; set; }
        public DbSet<Pronoun> Pronoun { get; set; }

    }
}
