using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata.Internal;

namespace WwcUrpApi.Models
{
    public class Accomplishment
    {
        [Key]
        public int AccomplishmentId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int Year { get; set; }
        public virtual Person Person { get; set; }
    }
}