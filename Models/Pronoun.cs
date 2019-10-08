using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WwcUrpApi.Models
{
    public class Pronoun
    {
        [Key]
        public int PronounId { get; set; }
        public string Subject { get; set; }
        public string Object { get; set; }
        public string Posessive { get; set; }
    }
}
