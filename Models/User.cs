using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Blog3.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [Required]
        [MinLength(5), MaxLength(100)]
        public string FullName { get; set; }

        public List<Article> Articles { get; set; }
    }
}
