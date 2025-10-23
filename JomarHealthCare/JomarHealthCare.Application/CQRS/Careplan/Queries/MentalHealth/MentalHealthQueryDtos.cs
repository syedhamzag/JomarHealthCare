using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.MentalHealth;

public record GetByClientMentalHealthQuery(Guid clientId) : IRequest<MentalHealthSupportDataModel>;
