using AutoMapper;
using Delta.Trinity.Auth;
using Delta.Trinity.DataAccess.ViewModels;

namespace Delta.Trinity.DataAccess.AutoMapper.Outbound.Auth
{
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<Account, AccountViewModel>();
        }
    }
}