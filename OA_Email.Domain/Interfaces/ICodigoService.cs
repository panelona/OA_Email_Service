using OA_Email.Domain.Contracts;

namespace OA_Email.Domain.Interfaces
{
    public interface ICodigoService
    {
        Task<string> gerarCodigoConfirmacaoAsync(EmailRequest request, Guid id);
    }
}
