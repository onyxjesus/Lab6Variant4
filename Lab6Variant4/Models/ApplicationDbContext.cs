using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6Variant4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Call_Centers> Call_Centers{ get; set; }
        public DbSet<Common_Problems> Common_Problems { get; set; }
        public DbSet<Common_Solutions> Common_Solutions { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Customer_Calls> Customer_Calls { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Ref_Call_Outcomes> Ref_Call_Outcomes { get; set; }
        public DbSet<Ref_Call_Status_Codes> Ref_Call_Status_Codes { get; set; }
        public DbSet<Solutions_for_Common_Problems> Solutions_for_Common_Problems { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
