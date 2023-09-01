using AutoFixture;
using AutoMapper;
using Moq;
using OA_Email.Domain.Contracts;
using OA_Email.Domain.Entities;
using OA_Email.Domain.Interfaces;
using OA_Email.Service.Services;
using OA_Email.Tests.Configs;

namespace OA_Email.Tests.Service
{
    [Trait("Service", "Codigo Service")]
    public class CodigoServiceTest
    {
        private readonly Mock<ICodigoEmailRepository> _mockcodigoEmailRepository;

        private readonly IMapper _mapper;

        private readonly Fixture _fixture;

        public CodigoServiceTest()
        {
            _mockcodigoEmailRepository = new Mock<ICodigoEmailRepository>();
            _mapper = MapperConfig.Get();
            _fixture = FixtureConfig.Get();
        }

        [Fact(DisplayName = "Criar código")]
        public async Task AddCodigo()
        {
            var entity = _fixture.Create<CodigoEmail>();
            var request = _fixture.Create<EmailRequest>();

            _mockcodigoEmailRepository.Setup(mock => mock.CriarEntidade(entity));

            var service = new CodigoService(_mockcodigoEmailRepository.Object, _mapper);

            var exception = await Record.ExceptionAsync(async () => await service.gerarCodigoConfirmacaoAsync(request, entity.Id));
            Assert.Null(exception);

        }
    }
}
