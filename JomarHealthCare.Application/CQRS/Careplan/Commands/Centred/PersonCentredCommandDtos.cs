using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Centred;


public record CreatePersonCentredCommand(List<PersonCentredModelData> DataModel) : IRequest<List<PersonCentredModelData>>;