using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;

namespace CompanyForum.Application.Interfaces;

public interface ITagService : IService<TagRequest, TagResponse>;