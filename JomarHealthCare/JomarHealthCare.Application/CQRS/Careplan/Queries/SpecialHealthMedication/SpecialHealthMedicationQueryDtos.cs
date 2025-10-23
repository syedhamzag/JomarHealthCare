using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.SpecialHealthMedication;


public record GetByClientSpecialHealthMedicationQuery(Guid clientId) : IRequest<SpecialHealthAndMedicationDataModel>;
