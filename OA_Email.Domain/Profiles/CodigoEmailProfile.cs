using AutoMapper;
using OA_Email.Domain.Contracts;
using OA_Email.Domain.Entities;

namespace OA_Email.Api.Profiles
{
    public class CodigoEmailProfile : Profile
    {
        public CodigoEmailProfile()
        {
            CreateMap<EmailRequest, CodigoEmail>().ReverseMap();
            CreateMap<EmailResponse, CodigoEmail>().ReverseMap();
        }
    }
}
