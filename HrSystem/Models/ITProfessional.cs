using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrSystem.Models
{
    public class ITProfessional
    {
        [Required(ErrorMessage = "please enter firstname")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Years Of Experience")]

        [Required]
        public int YearsOfEx { get; set; }
        public string Id { get; set; }
        
        [Required]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Technology Stack")]

        public string TechnologyStack { get; set; }
        [Display(Name = "Certifications")]
        public int MaxAge { get; set; }

    }
}