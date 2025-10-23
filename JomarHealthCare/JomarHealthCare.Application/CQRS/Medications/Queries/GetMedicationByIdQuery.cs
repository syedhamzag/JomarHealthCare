using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Medications.Queries
{
    public record GetMedicationByIdQuery(int Id) : IRequest<List<Medication>>;
    
    
}
