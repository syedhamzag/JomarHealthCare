using MediatR;
using JomarHealthCare.Application.DataModels.ServiceType;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Queries;

public record GetServiceTypeByIdQuery(int id) : IRequest<ServiceTypeDataModel>;

public record GetAllServiceTypeQuery() : IRequest<List<ServiceTypeDataModel>>;

public record GetAllServiceTypeCompanyIdQuery(Guid companyId) : IRequest<List<ServiceTypeDataModel>>;
