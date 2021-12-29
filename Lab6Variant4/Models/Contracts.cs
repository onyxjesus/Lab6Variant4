using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Contracts
    {
        [Key]
        public int contract_ID { get; set; }
        public int customer_ID { get; set; }
        public DateTime contract_Start_Date { get; set; }
        public DateTime contract_End_Date { get; set; }
        public string other_Details { get; set; }
        public Customers customers { get; set; }
    }
}
