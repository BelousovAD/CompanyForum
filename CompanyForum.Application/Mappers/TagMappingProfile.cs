using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Mappers;

internal class TagMappingProfile : Profile
{
    public TagMappingProfile()
    {
        CreateMap<TagRequest, Tag>();
        CreateMap<Tag, TagResponse>();
    }
}