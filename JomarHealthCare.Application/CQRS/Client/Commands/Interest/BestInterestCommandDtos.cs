using MediatR;
using JomarHealthCare.Application.DataModels.Client.BestInterest;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Interest;

public record CreateClientBestInterestCommand(BestInterestDataModel DataModel) : IRequest<BestInterestDataModel>;
public record UpdateClientBestInterestCommand(BestInterestDataModel DataModel) : IRequest<bool>;