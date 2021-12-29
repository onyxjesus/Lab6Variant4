using Lab6Variant4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Controllers
{
    public class StaffController : Controller
    {
        private readonly ILogger<StaffController> _logger;
        private readonly ApplicationDbContext _dBcontext;

        public StaffController(ILogger<StaffController> logger, ApplicationDbContext dBcontext)
        {
            _logger = logger;
            _dBcontext = dBcontext;
        }
        [HttpGet("api/GetStaffs")]
        public async Task<List<Staff>> GetStaffs()
        {
            return await _dBcontext.Staff.ToListAsync();
        }
        [HttpPost("api/PostStaff")]
        public async Task<IActionResult> PostStaff(Staff staff)
        {
            _dBcontext.Staff.Add(staff);
            await _dBcontext.SaveChangesAsync();
            return Ok();
        }
    }
}
