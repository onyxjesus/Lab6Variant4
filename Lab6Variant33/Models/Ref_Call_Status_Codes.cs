using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Ref_Call_Status_Codes
    {
        [Key]
        public int call_Status_Code { get; set; }
        public string call_Status_Description { get; set; }
        public string call_Status_Comments { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
