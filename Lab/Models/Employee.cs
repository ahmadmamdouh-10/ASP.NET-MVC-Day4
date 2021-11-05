using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Models
{
    public enum Gender { Male, Female }

    public class Employee
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Hiring Date")]
        public DateTime HiringDate { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
    }
}