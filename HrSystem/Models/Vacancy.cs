using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HrSystem.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        [Display(Name = "Job Title")]

        public string JobTitle { get; set; }
        [Display(Name = "Job Type")]

        public string JobType { get; set; }
        [Display(Name = "Job Descreprion")]

        public string JobDescreption { get; set; }
        [Display(Name = "Maximumm Age")]

        public int MaxAge { get; set; }



    }
}