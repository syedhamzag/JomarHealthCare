using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Hygiene;

public record GetByClientPersonalHygieneQuery(Guid clientId) : IRequest<PersonalHygieneDataModel>;

