using MediatR;
using JomarHealthCare.Application.DataModels.AreaCode;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Queries;
public record GetAreaCodeByIdQuery(int id) : IRequest<AreaCodeDataModel>;

public record GetAllAreaCodeQuery() : IRequest<List<AreaCodeDataModel>>;

public record GetAllAreaCodeByCompanyIdQuery(Guid companyId) : IRequest<List<AreaCodeDataModel>>;
