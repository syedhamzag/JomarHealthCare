using MediatR;
using JomarHealthCare.Application.DataModels.Company;

namespace JomarHealthCare.Application.CQRS.Company.Queries;

public record GetCompanyByCode(string code) : IRequest<CompanyDataModel>;

public record GetAllCompanyQuery() : IRequest<List<CompanyDataModel>>;


public record GetCompanyForProfileSettingQuery(Guid CompanyId) : IRequest<CompanyPorfileSettingDataModel>;

