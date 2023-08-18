using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Domain.Entities
{
    public class CodigoEmail
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public DateTime GeradoEm { get; set; }
    }
}
