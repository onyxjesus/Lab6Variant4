using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Customers
    {
        [Key]
        public int customer_ID { get; set; }
        public string customer_Address_line_1 { get; set; }
        public string customer_Address_line_2 { get; set; }
        public string customer_Address_line_3 { get; set; }
        public string town_city { get; set; }
        public string state { get; set; }
        public string email_Address { get; set; }
        public string phone_Number { get; set; }
        public string customer_Other_Details { get; set; }
        public List<Contracts> contracts { get; set; }
        public List<Customer_Calls> customer_Calls { get; set; }
    }
}
