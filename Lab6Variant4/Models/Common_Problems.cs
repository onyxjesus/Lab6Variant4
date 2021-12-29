using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Common_Problems
    {
        [Key]
        public int problem_ID { get; set; }
        public string problem_Description { get; set; }
        public string other_Problem_Details { get; set; }
        public List<Solutions_for_Common_Problems> solutions_For_Common_Problems { get; set; }
    }
}