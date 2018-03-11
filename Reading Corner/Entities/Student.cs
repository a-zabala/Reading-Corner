﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reading_Corner.Entities
{
    public class Student
    {

        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Teacher { get; set; }
        [Display(Name = "Current Book")]
        public string CurrentBook { get; set; }
    }
}
