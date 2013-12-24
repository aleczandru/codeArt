using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeArt.DomainServices.Contracts.Models.Membership
{
    public class UserModel : IdentityUser
    {
        [EmailAddress(ErrorMessage = "You must provide a valid e-mail address")]
        [Required(ErrorMessage = "The e-mail address is required")]
        public override string UserName { get; set; }
        [Required]
        [NotMapped]
        public string Password { get; set; }
        [Required]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int Gender { get; set; }

        public bool IsTermsAndConditionChecked { get; set; }
    }
}
