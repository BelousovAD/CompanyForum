using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Services;

public class TagService(ITagRepository repository, IMapper mapper)
    : BaseService<Tag, ITagRepository, TagRequest, TagResponse>(repository, mapper), ITagService;