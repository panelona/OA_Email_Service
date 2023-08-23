using System.ComponentModel.DataAnnotations;

namespace OA_Email.Domain.Contracts
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
