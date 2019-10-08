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
        public int PersonId{ get; set; }
        public string FullName { get; set; }
        public string CommonName { get; set; }
        public int BirthYear { get; set; }
        public string Description { get; set; }
        public virtual Pronoun Pronoun { get; set; }
    }
}
