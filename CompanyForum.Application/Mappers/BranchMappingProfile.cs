using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Mappers;

internal class BranchMappingProfile : Profile
{
    public BranchMappingProfile()
    {
        CreateMap<BranchRequest, Branch>();
        CreateMap<Branch, BranchResponse>();
    }
}