using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Ref_Call_Outcomes
    {
        [Key]
        public int call_Outcome_Code { get; set; }
        public string call_Outcome_Description { get; set; }
        public string other_Call_Outcome_Details { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
