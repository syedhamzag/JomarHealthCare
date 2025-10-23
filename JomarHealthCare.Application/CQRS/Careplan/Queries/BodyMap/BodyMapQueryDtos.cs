using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.BodyMap;


public record GetByClientBodyMapQuery(Guid clientId) : IRequest<List<BodyMapDataModel>>;
public record GetByIdBodyMapQuery(int id) : IRequest<BodyMapDataModel>;
