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
        [StringLength(80, ErrorMessage = "Company Name cannot be longer than 80 characters.")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Address First Line")]
        [StringLength(80, ErrorMessage = "Address must be between 4 and 80 characters.", MinimumLength = 4)]
        public string CompanyAddress1 { get; set; }

        [Display(Name = "Address Second Line")]
        [StringLength(80, ErrorMessage = "Address cannot be longer than 80 characters.")]
        public string CompanyAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "City cannot be longer than 50 characters.")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        [StringLength(80, ErrorMessage = "Company State must be 2 characters.", MinimumLength = 2)]
        public string CompanyState { get; set; }

        [Required]
        [Display(Name = "Zip")]
        [StringLength(80, ErrorMessage = "Company Zip cannot be longer than 9 characters.", MinimumLength = 5)]
        public string CompanyZip { get; set; }

        [Required]
        [Display(Name = "Country")]
        [StringLength(50, ErrorMessage = "Country must be between 4 and 50 characters.", MinimumLength = 4)]
        public string CompanyCountry { get; set; }

        [Required]
        [Display(Name = "Contact")]
        [StringLength(50, ErrorMessage = "Contact Name cannot be longer than 50 characters.")]
        public string ContactName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Phone must be between 10 and 25 characters.", MinimumLength = 10)]
        [Phone]
        public string Phone { get; set; }
        
        [StringLength(1000, ErrorMessage = "Company Description cannot be longer than 1000 characters.", MinimumLength = 0)]
        public string CompanyNotes { get; set; }

        [Required]
        [EmailAddress]
        public string CompanyEmail { get; set; }


        //Billing
        [Required]
        [Display(Name = "Billing Name")]
        [StringLength(80, ErrorMessage = "Billing Name cannot be longer than 80 characters.")]
        public string BillingName { get; set; }

        [Required]
        [Display(Name = "Address First Line")]
        [StringLength(80, ErrorMessage = "Address must be between 4 and 80 characters.", MinimumLength = 4)]
        public string BillingAddress1 { get; set; }

        [Display(Name = "Address Second Line")]
        [StringLength(80, ErrorMessage = "Address cannot be longer than 80 characters.")]
        public string BillingAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "City cannot be longer than 50 characters.")]
        public string BillingCity { get; set; }

        [Required]
        [Display(Name = "State")]
        [StringLength(80, ErrorMessage = "Billing State must be 2 characters.", MinimumLength = 2)]
        public string BillingState { get; set; }

        [Required]
        [Display(Name = "Zip")]
        [StringLength(80, ErrorMessage = "Billing Zip cannot be longer than 9 characters.", MinimumLength = 5)]
        public string BillingZip { get; set; }

        [Required]
        [Display(Name = "Country")]
        [StringLength(50, ErrorMessage = "Country must be between 4 and 50 characters.", MinimumLength = 4)]
        public string BillingCountry { get; set; }

        [Required]
        [Display(Name = "Contact")]
        [StringLength(50, ErrorMessage = "Contact Name cannot be longer than 50 characters.")]
        public string BillingContactName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Phone must be between 10 and 25 characters.", MinimumLength = 10)]
        [Phone]
        public string BillingPhone { get; set; }

        [StringLength(1000, ErrorMessage = "Billing Notes cannot be longer than 1000 characters.", MinimumLength = 0)]
        public string BillingNotes { get; set; }

        [Required]
        [EmailAddress]
        public string BillingEmail { get; set; }

    }
}