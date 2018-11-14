using AutoMapper;
using Delta.Trinity.DataAccess.AutoMapper.Outbound.Auth;

namespace Delta.Trinity.DataAccess.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AccountMappingProfile());
            });
        }
    }
}