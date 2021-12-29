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
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ApplicationDbContext _dBcontext;
        public CustomersController(ILogger<CustomersController> logger, ApplicationDbContext dBcontext)
        {
            _logger = logger;
            _dBcontext = dBcontext;
        }
        [HttpGet("api/GetCustomers")] //2 JOINS
        public async Task<List<Customers>> GetCustomers()
        {
            return await _dBcontext.Customers
                .Include(c => c.contracts)
                .Include(c => c.customer_Calls)
                .ToListAsync();
        }
    }
}
