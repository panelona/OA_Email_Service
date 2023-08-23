using Microsoft.EntityFrameworkCore;
using OA_Email.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<CodigoEmail> CodigosEmail { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
