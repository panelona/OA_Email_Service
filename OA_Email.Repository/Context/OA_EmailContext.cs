using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Repository.Context
{
    public class OA_EmailContext : DbContext
    {
        public OA_EmailContext(DbContextOptions<OA_EmailContext> options) : base(options) { }
    }
}
