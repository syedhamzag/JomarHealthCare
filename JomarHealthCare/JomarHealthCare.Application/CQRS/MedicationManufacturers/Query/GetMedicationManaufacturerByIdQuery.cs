using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Query
{
    public record GetMedicationManaufacturerByIdQuery(int Id): IRequest<List<MedicationManufacturer>>;
   
}
    