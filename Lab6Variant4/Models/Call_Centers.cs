using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Call_Centers
    {
        [Key]
        public int call_Center_ID { get; set; }
        public string call_Center_Address { get; set; }
        public string call_Center_Other_Details { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
