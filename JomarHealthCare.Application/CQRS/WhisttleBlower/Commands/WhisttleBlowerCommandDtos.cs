using MediatR;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Commands;


public record AddWhisttleBlowerCommand(WhisttleBlowerDataModel DataModel) : IRequest<WhisttleBlowerDataModel>;
public record DeleteWhisttleBlowerCommand(int id) : IRequest<bool>;
public record UpdateWhisttleBlowerCommand(WhisttleBlowerDataModel DataModel) : IRequest<bool>;
