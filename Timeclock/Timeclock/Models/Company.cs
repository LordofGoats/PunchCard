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
        [StringLength(80, ErrorMessage = "Company Name cannot be longer than 80 characters.",MinimumLength=4)]
        public string CompanyName { get; set; }

        [Display(Name = "Company Address First Line")]
        [StringLength(80, ErrorMessage = "Address must be between 4 and 80 characters.", MinimumLength = 4)]
        public string CompanyAddress1 { get; set; }

        [Display(Name = "Company Address Second Line")]
        [StringLength(80, ErrorMessage = "Address cannot be longer than 80 characters.")]
        public string CompanyAddress2 { get; set; }

        [Display(Name = "Company City")]
        [StringLength(50, ErrorMessage = "City cannot be longer than 50 characters.")]
        public string City { get; set; }

        [Display(Name = "Company State")]
        [StringLength(80, ErrorMessage = "Company State must be 2 characters.", MinimumLength = 2)]
        public string CompanyState { get; set; }

        [Display(Name = "Company Zip")]
        [StringLength(80, ErrorMessage = "Company Zip cannot be longer than 9 characters.", MinimumLength = 5)]
        public string CompanyZip { get; set; }

        [Display(Name = "Company Country")]
        [StringLength(50, ErrorMessage = "Country must be between 4 and 50 characters.", MinimumLength = 4)]
        public string CompanyCountry { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Contact Name cannot be longer than 50 characters.", MinimumLength = 4)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Phone must be between 7 and 25 characters.", MinimumLength = 7)]
        [Phone]
        public string Phone { get; set; }
        
        [StringLength(1000, ErrorMessage = "Company Description cannot be longer than 1000 characters.", MinimumLength = 0)]
        public string CompanyDescription { get; set; }

        [Required]
        [EmailAddress]
        public string CompanyEmail { get; set; }

        [StringLength(80, ErrorMessage = "Billing Name cannot be longer than 80 characters.")]
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