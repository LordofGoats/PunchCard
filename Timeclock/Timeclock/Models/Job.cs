using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timeclock.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
    }
}