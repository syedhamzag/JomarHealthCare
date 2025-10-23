using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.MentalHealth;

public record CreateMentalHealthCommand(MentalHealthSupportDataModel DataModel) : IRequest<MentalHealthSupportDataModel>;
public record UpdateMentalHealthCommand(MentalHealthSupportDataModel DataModel) : IRequest<bool>;