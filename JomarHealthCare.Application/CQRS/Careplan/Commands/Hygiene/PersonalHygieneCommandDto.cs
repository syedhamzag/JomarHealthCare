using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Hygiene;

public record CreatePersonalHygieneCommand(PersonalHygieneDataModel DataModel) : IRequest<PersonalHygieneDataModel>;
public record UpdatePersonalHygieneCommand(PersonalHygieneDataModel DataModel) : IRequest<bool>;
