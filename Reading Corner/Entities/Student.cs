using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Display(Name = "Current Book"), NotMapped]
        public string CurrentBook {
            get
            {
                if (ReadingRecords != null && ReadingRecords.Count > 0)
                {
                    return ReadingRecords.OrderByDescending(x => x.LogDate).FirstOrDefault().Name;
                }
                return string.Empty;
                
            }
        }

        public virtual List<ReadingRecord> ReadingRecords { get; set; }
    }
}
