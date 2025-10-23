using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Centred;


public record GetByClientPersonCentredQuery(Guid clientId) : IRequest<List<GetPersonCentredModelData>>;