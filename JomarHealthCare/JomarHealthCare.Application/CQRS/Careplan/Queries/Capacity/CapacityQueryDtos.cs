using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Capacity;
public record GetByClientCapacityQuery(Guid clientId) : IRequest<CapacityDataModel>;
