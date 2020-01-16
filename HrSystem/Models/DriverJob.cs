using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrSystem.Models
{
    public class DriverJob
    {
        [Required(ErrorMessage = "please enter firstname")]
        [Display(Name ="First Name")]
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
        [Display(Name = "literacy")]

        public bool AbilityToReadAndWrite { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [Display(Name = "License Level")]

        public int licenselvl { get; set; }
        public int? MaxAge { get; set; }


    }
}