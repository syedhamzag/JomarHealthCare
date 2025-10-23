using MediatR;
using JomarHealthCare.Application.DataModels.HealthCondition;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Queries;
public record GetHealthConditionByIdQuery(int HCId) : IRequest<HealthConditionModelData>;

public record GetAllHealthConditionQuery() : IRequest<List<HealthConditionModelData>>;

public record GetAllHealthConditionByCompanyIdIdQuery(Guid companyId) : IRequest<List<HealthConditionModelData>>;
