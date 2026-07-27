using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Mappers;

internal class CommentMappingProfile : Profile
{
    public CommentMappingProfile()
    {
        CreateMap<CommentRequest, Comment>();
        CreateMap<Comment, CommentResponse>();
    }
}