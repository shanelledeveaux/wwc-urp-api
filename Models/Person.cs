using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata.Internal;

namespace WwcUrpApi.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string CommonName { get; set; }
        public int BirthYear { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public virtual Pronoun Pronoun { get; set; }
        public int DeathYear { get; set; }
        public ICollection<Accomplishment> Accomplishments { get; set; }
        public ICollection<Education> Education { get; set; }
        public ICollection<Home> Home { get; set; }
        public ICollection<Location> Location { get; set; }
        public ICollection<OtherAssociation> OtherAssociations { get; set; }
    }
}
