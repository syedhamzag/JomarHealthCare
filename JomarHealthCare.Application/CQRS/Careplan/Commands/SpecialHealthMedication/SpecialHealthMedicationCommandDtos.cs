using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.SpecialHealthMedication;


public record CreateSpecialHealthMedicationCommand(SpecialHealthAndMedicationDataModel DataModel) : IRequest<SpecialHealthAndMedicationDataModel>;
public record UpdateSpecialHealthMedicationCommand(SpecialHealthAndMedicationDataModel DataModel) : IRequest<bool>;