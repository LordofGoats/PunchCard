using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timeclock.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
        public string CompanyCountry { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        public string Phone { get; set; }
        
        public string CompanyDescription { get; set; }

        [Required]
        public string CompanyEmail { get; set; }

        public string BillingName { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string BillingCountry { get; set; }

        public string BillingContact { get; set; }

        public string BillingPhone { get; set; }

        public string BillingNotes { get; set; }

        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public string ShiftName { get; set; }
    }
}