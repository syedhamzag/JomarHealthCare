using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Keyworker;


public record CreateKeyworkerCommand(KeyworkerDataModel DataModel) : IRequest<KeyworkerDataModel>;
public record UpdateKeyworkerCommand(KeyworkerDataModel DataModel) : IRequest<bool>;