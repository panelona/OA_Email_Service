using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Domain.Contracts
{
    public class EmailResponse
    {
        [Required]
        public string Codigo { get; set; }
    }
}
