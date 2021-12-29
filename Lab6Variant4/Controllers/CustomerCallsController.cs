using Lab6Variant4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Controllers
{
    public class CustomerCallsController : Controller
    {
        private readonly ILogger<CustomerCallsController> _logger;
        private readonly ApplicationDbContext _dBcontext;
        public CustomerCallsController(ILogger<CustomerCallsController> logger, ApplicationDbContext dBcontext)
        {
            _logger = logger;
            _dBcontext = dBcontext;
        }
        [HttpGet("api/GetCustomerCallsByDateTime")]
        public async Task<List<Customer_Calls>> GetCustomerCallsByDateTime(DateTime dateTime)
        {
            return await _dBcontext.Customer_Calls
                .Where(c => c.call_Date_time == dateTime)
                .ToListAsync();
        }
        [HttpGet("api/GetCustomerCallsByIds")]
        public async Task<List<Customer_Calls>> GetCustomerCallsByDateTime(int[] callIds)
        {
            return await _dBcontext.Customer_Calls
                .Where(c => callIds.Contains(c.call_ID))
                .ToListAsync();
        }
        [HttpGet("api/GetCustomerCallFirst")]
        public async Task<Customer_Calls> GetCustomerCallFirst()
        {
            return await _dBcontext.Customer_Calls
                .FirstOrDefaultAsync();
        }
        [HttpGet("api/GetCustomerCallLast")]
        public async Task<Customer_Calls> GetCustomerCallLast()
        {
            return await _dBcontext.Customer_Calls
                .LastOrDefaultAsync();
        }
    }
}
