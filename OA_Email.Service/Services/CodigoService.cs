// Ignore Spelling: Confirmacao Codigo gerar OA

using AutoMapper;
using OA_Email.Domain.Contracts;
using OA_Email.Domain.Entities;
using OA_Email.Domain.Interfaces;
using System.Security.Cryptography;

namespace OA_Email.Service.Services
{
    public class CodigoService : ICodigoService
    {
        private readonly ICodigoEmailRepository _repository;
        private readonly IMapper _mapper;

        public CodigoService(ICodigoEmailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> gerarCodigoConfirmacaoAsync(EmailRequest request, Guid id)
        {
            var entity = _mapper.Map<CodigoEmail>(request);

            entity.Codigo = CreateRandomToken();
            entity.GeradoEm = DateTime.Now;
            entity.Id = id;
            var response = _mapper.Map<EmailResponse>(entity);
            await _repository.CriarEntidade(entity);

            return response.Codigo;
        }

        public string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(2));
        }
    }
}
