using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;

namespace CompanyForum.Application.Interfaces;

public interface IIssueService : IService<IssueRequest, IssueResponse>;