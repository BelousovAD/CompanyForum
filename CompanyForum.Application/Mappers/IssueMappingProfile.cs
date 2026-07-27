using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Mappers;

internal class IssueMappingProfile : Profile
{
    public IssueMappingProfile()
    {
        CreateMap<IssueRequest, Issue>();
        CreateMap<Issue, IssueResponse>();
    }
}