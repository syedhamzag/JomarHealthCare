using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Personal;
public record GetByClientPersonalQuery(Guid clientId) : IRequest<PersonalDataModel>;
