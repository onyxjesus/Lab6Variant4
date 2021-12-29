using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class Customer_Calls
    {
        [Key]
        public int call_ID { get; set; }
        public int customer_ID { get; set; }
        public int call_Center_id { get; set; }
        public int call_Outcome_Code { get; set; }
        public int call_Status_Code { get; set; }
        public int recommended_Solution_ID { get; set; }
        public int staff_ID { get; set; }
        public DateTime call_Date_time { get; set; }
        public string call_Description { get; set; }
        public string tailored_Solution_Description { get; set; }
        public string call_Other_Details { get; set; }
        public Common_Solutions common_Solutions { get; set; }
        public Staff staff { get; set; }
        public Ref_Call_Status_Codes ref_Call_Status_Codes { get; set; }
        public Ref_Call_Outcomes ref_Call_Outcomes { get; set; }
        public Call_Centers call_Centers { get; set; }
        public Customers customers { get; set; }
    }
}
