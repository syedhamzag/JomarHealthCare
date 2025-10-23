using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.PhysicalAbility;

public record GetByClientPhysicalAbilityQuery(Guid clientId) : IRequest<List<PhysicalAbilityDataModel>>;
public record GetByIdPhysicalAbilityQuery(int id) : IRequest<PhysicalAbilityDataModel>;
