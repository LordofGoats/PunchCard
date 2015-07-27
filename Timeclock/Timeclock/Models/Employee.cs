using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace Timeclock.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string EmployeeEmail { get; set; }
        public bool Active { get; set; }
        public string EmployeePassword { get; set; }
        public DateTimeOffset EmployeeTimezone { get; set; }
        public bool ManualTimeEntry { get; set; }
        public bool AllowChangePassword { get; set; }
        
        //Navigation Properties
        public virtual ICollection<Manager> Managers { get; set; }

        ////Constructor
        //public Employee()
        //{
        //    this.Managers = new HashSet<Manager>();
        //}
    }
}