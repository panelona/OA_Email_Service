using OA_Email.Domain.Entities;
using OA_Email.Domain.Interfaces;
using OA_Email.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Repository.Repositories
{
    public class CodigoEmailRepository : BaseRepository<CodigoEmail>, ICodigoEmailRepository
    {
        public CodigoEmailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
