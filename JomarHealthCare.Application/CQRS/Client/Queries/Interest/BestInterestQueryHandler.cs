using MediatR;
using JomarHealthCare.Application.DataModels.Client.BestInterest;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Interest;

public record GetByClientBestInterestQuery(Guid clientId) : IRequest<BestInterestDataModel>;
