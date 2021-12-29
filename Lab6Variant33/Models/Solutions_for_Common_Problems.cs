using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Solutions_for_Common_Problems
    {
        [Key]
        public int problem_ID { get; set; }
        public int solution_ID { get; set; }
        public Common_Problems common_Problems { get; set; }
        public Common_Solutions common_Solutions { get; set; }
    }
}
