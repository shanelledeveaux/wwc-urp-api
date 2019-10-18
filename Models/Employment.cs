using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata.Internal;

namespace WwcUrpApi.Models
{
    public class Employment
    {
        [Key]
        public int EmploymentId { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public virtual Person Person { get; set; }
        public string Notes { get; set; }
    }
}