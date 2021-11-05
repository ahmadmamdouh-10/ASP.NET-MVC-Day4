using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Storage
{
    public class PermenantData
    {
        static PermenantData()
        {
            Employees = new List<Employee>()
            {
                new Employee{ ID=1, Name="Karim", Gender= Gender.Male, HiringDate= new DateTime(2010,10,22)},
                new Employee{ ID=2, Name="Moataz", Gender= Gender.Male, HiringDate= new DateTime(2008,10,22)},
                new Employee{ ID=3, Name="Naira", Gender= Gender.Female, HiringDate= new DateTime(2010,10,22)}
            };
        }
        public static List<Employee>
            Employees
        { get; set; }

    }
}