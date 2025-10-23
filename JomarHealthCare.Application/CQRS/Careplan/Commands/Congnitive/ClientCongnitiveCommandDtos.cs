using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Congnitive;


public record CreateCongnitiveCommand(CongnitiveDataModel DataModel) : IRequest<CongnitiveDataModel>;
public record UpdateCongnitiveCommand(CongnitiveDataModel DataModel) : IRequest<bool>;