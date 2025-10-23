using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Personal;
public record CreatePersonalCommand(PersonalDataModel DataModel) : IRequest<PersonalDataModel>;
public record UpdatePersonalCommand(PersonalDataModel DataModel) : IRequest<bool>;