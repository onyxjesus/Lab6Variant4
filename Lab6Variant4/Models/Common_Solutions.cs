using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Common_Solutions
    {
        [Key]
        public int solution_ID { get; set; }
        public string solution_Description { get; set; }
        public string other_Solution_Details { get; set; }
        public List<Solutions_for_Common_Problems> solutions_For_Common_Problems { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
