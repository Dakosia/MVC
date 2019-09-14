//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCExamShop.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 32 characters!")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "E-Mail Address does not appear to be valid!")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Enquiry")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Enquiry must be between 10 and 3000 characters!")]
        public string UserMessage { get; set; }
    }
}
