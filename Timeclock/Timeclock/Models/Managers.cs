using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class Manager
    {
        [Key]
        [Display(Name = "Manager Name")]
        [Range(0, 50)]
        public string ManagerName { get; set; }

        [Display(Name = "Manager Title")]
        [Range(0, 50)]
        public string ManagerTitle { get; set; }
    }
}