using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata.Internal;

namespace WwcUrpApi.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string CountryFullName { get; set; }
        public string CountryCommonName { get; set; }
        public string CountryAbbreviation { get; set; }
        public string RegionDesription { get; set; }
        public string RegionAbbreviation { get; set; }
        public string MetroArea { get; set; }
    }
}