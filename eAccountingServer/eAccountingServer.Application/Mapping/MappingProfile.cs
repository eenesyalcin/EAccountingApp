using AutoMapper;
using eAccountingServer.Application.Features.Companies.CreateCompany;
using eAccountingServer.Application.Features.Companies.UpdateCompany;
using eAccountingServer.Application.Features.Users.CreateUser;
using eAccountingServer.Application.Features.Users.UpdateUser;
using eAccountingServer.Domain.Entities;

namespace eAccountingServer.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserCommand, AppUser>();
            CreateMap<UpdateUserCommand, AppUser>();

            CreateMap<CreateCompanyCommand, Company>();
            CreateMap<UpdateCompanyCommand, Company>();
        }
    }
}
