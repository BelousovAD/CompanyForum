using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Mappers;

internal class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserRequest, User>();
        CreateMap<User, UserResponse>();
    }
}