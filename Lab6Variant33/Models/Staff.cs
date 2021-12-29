using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Staff
    {
        [Key]
        public int staff_ID { get; set; }
        public string email_Address { get; set; }
        public string phone_Number { get; set; }
        public string Other_Details { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
