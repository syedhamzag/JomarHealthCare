using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.KeyIndicator;


public record CreateKeyIndicatorCommand(KeyIndicatorDataModel DataModel) : IRequest<KeyIndicatorDataModel>;
public record UpdateKeyIndicatorCommand(KeyIndicatorDataModel DataModel) : IRequest<bool>;
