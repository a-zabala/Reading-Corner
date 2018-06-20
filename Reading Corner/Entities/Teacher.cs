using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reading_Corner.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Display(Name = "Class Size")]
        public int ClassSize { get
        {if (Students == null) return 0;
                return Students.Count;
            } }
        public List<Student> Students { get; set; }



    }
}
