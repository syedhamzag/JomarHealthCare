using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Medications.Queries
{
    public class GetAllMedicationQuery: IRequest<List<Medication>>;
   
}
