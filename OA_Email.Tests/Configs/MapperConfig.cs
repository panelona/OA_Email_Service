using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Tests.Configs
{
    public static class MapperConfig
    {
        public static IMapper Get()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Api.Profiles.CodigoEmailProfile());
            });

            return mockMapper.CreateMapper();
        }
    }
}
